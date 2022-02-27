using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStorage
{
    class Exportation
    {
        Ventes ventes = new Ventes();
        gestionReleve releve = new gestionReleve();
        public void ExportToPdf(DataGridView v,string nameClient,string tel,string etat)
        {
            int somme = 0;
          
            if (v.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                DateTime d = DateTime.Now;
                sfd.FileName = "Facture"+d.Year+"_"+d.Month+"_"+d.Day+"_"+d.Hour+"_"+d.Minute+"_"+d.Second.ToString()+".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {


                        try
                        {
                            var pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);//(PageSize.LETTER, 40f, 40f, 60f, 60f);
                                                                                       //string path = $"c:\\RazorCX\\Development\\{_model.GetProjectInfo().Name} {textBoxProperties.Text.TrimEnd(' ')}.pdf";

                            // string path = $"C:\\Users\\khalil\\source\\repos\\MesProjetsGT\\GestionMagasin\\Resources\\facture.pdf";

                            //PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                            

                            iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));

                            var spacer = new Paragraph("")
                            {
                                SpacingBefore = 10f,
                                SpacingAfter = 10f,
                            };
                            pdfDoc.Open();

                            pdfDoc.Add(spacer);

                            var imagepath = @"C:\Users\khalil\source\repos\MesProjetsGT\GestionMagasin\Resources\gt.jpg";
                            using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                            {
                                var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                png.ScalePercent(10f);
                               // png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                                pdfDoc.Add(png);
                            }

                           /* var spacer = new Paragraph("")
                            {
                                SpacingBefore = 10f,
                                SpacingAfter = 10f,
                            };*/
                         
                            pdfDoc.Add(new Paragraph("khalil.diop@gmail.com"));
                            pdfDoc.Add(spacer);
                            pdfDoc.Add(new Paragraph("Nom Client :"+ nameClient+"\n"));
                            pdfDoc.Add(new Paragraph("TEL :" + tel));
                            pdfDoc.Add(new Paragraph("Date : "+DateTime.Now.ToString()+ "\n"));
                            pdfDoc.Add(spacer);
                            var columnCount = v.ColumnCount;
                            var columnWidths = new[] {0.75f, 1.5f, 0.75f, 0.75f};

                            var table = new PdfPTable(columnWidths)
                            {
                                // HorizontalAlignment = Left,
                                HorizontalAlignment = (int)LeftRightAlignment.Left,
                                WidthPercentage = 100,
                                DefaultCell = { MinimumHeight = 22f }
                            };

                            var cell = new PdfPCell(new Phrase("FACTURE"))
                            {
                                Colspan = columnCount,
                                HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
                                MinimumHeight = 30f
                            };

                                        table.AddCell(cell);

                            
              
                            foreach (DataGridViewColumn column in v.Columns)
                            {
                                PdfPCell cells = new PdfPCell(new Phrase(column.HeaderText));
                                table.AddCell(cells);
                            }

                            foreach (DataGridViewRow row in v.Rows)
                            {
                                foreach (DataGridViewCell cells in row.Cells)
                                {
                                    
                                    if(cells.Value!=null)
                                    {
                                       // 
                                       
                                        table.AddCell(cells.Value.ToString());
                                    }
                                    
                                }
                                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                                {
                                    
                                    int QTE = Convert.ToInt32(row.Cells[0].Value.ToString());
                                    string name = row.Cells[1].Value.ToString();
                                    
                                  if(etat.Equals("Livré et non Payé") || etat.Equals("Payé et Livré"))
                                      ventes.updateQte(name,QTE);
                                 
                                    somme += Convert.ToInt32(row.Cells[3].Value.ToString());


                                }

                                
                            }

                            pdfDoc.Add(table);
                            //%%%%%%%%%%%%%%%%%

                           // pdfDoc.Add(spacer);

                            var headerTable = new PdfPTable(new[] { 0.75f, 1.5f, 0.75f, 0.75f })
                            {
                                // HorizontalAlignment = Left,
                                HorizontalAlignment = (int)LeftRightAlignment.Left,
                                WidthPercentage = 100,
                                DefaultCell = { MinimumHeight = 22f }
                            };

                            //ligne vide
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            ////////////////
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            headerTable.AddCell("");
                            //ligne vide
                           
                            
                            headerTable.AddCell("ETAT");
                            headerTable.AddCell(etat);
                            headerTable.AddCell("Prix a payer");                         
                            headerTable.AddCell(somme.ToString()+"f CFA");

                       
                            

                            pdfDoc.Add(headerTable);
                            //%%%%%%%%%%%%%%

                            //$$$$$$$$$$$$$$$$$$$$
                            /*
                            pdfDoc.Add(new Paragraph(".........................................................................................................................................................................."));

                            using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                            {
                                var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                png.ScalePercent(10f);
                                // png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                                pdfDoc.Add(png);
                            }

                           
                            pdfDoc.Add(new Paragraph("khalil.diop@gmail.com\n"));
                            pdfDoc.Add(spacer);

                            pdfDoc.Add(table);
                            

                            pdfDoc.Add(spacer);

                            pdfDoc.Add(headerTable);
                            */
                            //$$$$$$$$$$$$$$$$$$$$
                            MessageBox.Show("facture genere");
                            pdfDoc.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" error : " + ex.Message);
                        }


                      
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }
    }
}
