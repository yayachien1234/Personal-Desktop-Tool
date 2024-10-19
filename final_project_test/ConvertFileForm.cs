using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.MediaFoundation;
using System.Diagnostics;
using Aspose.Pdf;
using Aspose.Words.Saving;
using Image = System.Drawing.Image;
using System.Text;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;

namespace final_project_test
{
    public partial class ConvertFileForm : Form
    {

        private string filepath = "";
        private string savepath = "";
        private string fileType = "";
        private static string convertType = "";
        // temporary copy file to prevent Chinese coding error
        private string tempCopy = @"C:\tempCopy\tempCopy.";
        private string tempSave = @"C:\tempCopy\tempSave";

        public ConvertFileForm()
        {
            InitializeComponent();
        }

        private void ConvertFileForm_Load(object sender, EventArgs e)
        {
            lbl_SelectedFile.Text = "";
            lbl_saved.Text = "";

            cbx_image.Enabled = false;
            cbx_audio.Enabled = false;
            cbx_video.Enabled = false;
            cbx_other.Enabled = false;

            if (!Directory.Exists(@"C:\tempCopy"))
                Directory.CreateDirectory(@"C:\tempCopy");

            Bitmap b = new Bitmap(Image.FromFile(@"..\..\Resources\DragHint.png"));
            Image hint = ResizeImage(b, new Size(pbx_ConvertFile.Width, pbx_ConvertFile.Height));
            pbx_ConvertFile.Image = hint;
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All files (*.*)|*.*";
                ofd.FilterIndex = 1;

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;

                    lbl_SelectedFile.Text = filepath;
                    
                    fileType = filepath.Split('.')[1];
                    switch(fileType)
                    {
                        case "gif":
                        case "GIF":
                        case "bmp":
                        case "BMP":
                        case "png":
                        case "PNG":
                        case "ico":
                        case "ICO":
                        case "jpg":
                        case "JPG":
                        case "jpeg":
                        case "JPEG":
                            cbx_image.Enabled = true;
                            cbx_audio.Enabled = false;
                            cbx_video.Enabled = false;
                            cbx_other.Enabled = true;
                            break;
                        case "mp3":
                        case "MP3":
                        case "wav":
                        case "WAV":
                            cbx_image.Enabled = false;
                            cbx_audio.Enabled = true;
                            cbx_video.Enabled = false;
                            cbx_other.Enabled = false;
                            break;
                        case "avi":
                        case "AVI":
                        case "mp4":
                        case "MP4":
                        case "mov":
                        case "MOV":
                        case "wmv":
                        case "WMV":
                        case "flv":
                        case "FLV":
                            cbx_image.Enabled = false;
                            cbx_audio.Enabled = true;
                            cbx_video.Enabled = true;
                            cbx_other.Enabled = false;
                            break;
                        default:
                            cbx_image.Enabled = false;
                            cbx_audio.Enabled = false;
                            cbx_video.Enabled = false;
                            cbx_other.Enabled = true;
                            break;
                    }

                    lbl_saved.Text = "";

                    Icon icon = Icon.ExtractAssociatedIcon(filepath);
                    Bitmap b = icon.ToBitmap();
                    Image icon_image = ResizeImage(b, new Size(pbx_ConvertFile.Width, pbx_ConvertFile.Height));
                    pbx_ConvertFile.Image = icon_image;
                }
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = string.Format("{0} files (*{1})|*{1}", convertType.Remove(0,1), convertType);
                sfd.FilterIndex = 1;

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    savepath = sfd.FileName;
                    Image img;

                    switch (convertType)
                    {
                        case ".gif":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Gif);
                                img.Dispose();
                            }
                            catch(Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".bmp":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Bmp);
                                img.Dispose();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".png":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Png);
                                img.Dispose();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".ico":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Icon);
                                img.Dispose();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".jpg":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Jpeg);
                                img.Dispose();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".jpeg":
                            try
                            {
                                img = Image.FromFile(filepath);
                                img.Save(savepath, ImageFormat.Jpeg);
                                img.Dispose();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".mp3":
                            try
                            {
                                if(fileType == "wav" || fileType == "WAV")
                                {
                                
                                    MediaFoundationApi.Startup();
                                    using (var reader = new WaveFileReader(filepath))
                                    {
                                        MediaFoundationEncoder.EncodeToMp3(reader, savepath);
                                    }
                                }
                                else
                                {
                                    Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -b:a 192K -vn {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".wav":
                            try
                            {
                                if(fileType == "mp3" || fileType == "MP3")
                                {
                                    using (var reader = new Mp3FileReader(filepath))
                                    {
                                        WaveFileWriter.CreateWaveFile(savepath, reader);
                                    }
                                }
                                else
                                {
                                    Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    " -i {0} -b:a 192K -vn {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".avi":
                            try
                            {
                                Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -y -b 1024k -acodec copy -f avi {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".mp4":
                            try
                            {
                                Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -b:v 2M -vcodec copy -acodec copy -f mp4 {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".mov":
                            try
                            {
                                Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -acodec copy -vcodec copy -f mov {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".wmv":
                            try
                            {
                                Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -b:v 2M -vcodec copy -acodec copy {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".flv":
                            try
                            {
                                Debug.WriteLine(FFMEPG_RunProcess(string.Format(
                                    "-i {0} -y -b 1024k -acodec copy -f flv {1}",
                                    FileCopy(), tempSave + convertType)));
                                    FileSave();
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        case ".pdf":
                            try
                            {
                                switch (fileType)
                                {
                                    case "doc":
                                    case "DOC":
                                    case "docx":
                                    case "DOCX":
                                        Aspose.Words.Document doc = new Aspose.Words.Document(filepath);
                                        Aspose.Words.Saving.PdfSaveOptions pso = new Aspose.Words.Saving.PdfSaveOptions();
                                        pso.ImageCompression = PdfImageCompression.Auto;
                                        doc.Save(savepath, pso);
                                        break;
                                    case "jpg":
                                    case "JPG":
                                    case "png":
                                    case "PNG":
                                        img = Image.FromFile(filepath);
                                        int h = img.Height;
                                        int w = img.Width;

                                        Aspose.Pdf.Document imgDoc = new Aspose.Pdf.Document();
                                        Page page = imgDoc.Pages.Add();
                                        Aspose.Pdf.Image asImg = new Aspose.Pdf.Image();
                                        asImg.File = filepath;

                                        page.PageInfo.Height = h;
                                        page.PageInfo.Width = w;
                                        page.PageInfo.Margin.Bottom = (0);
                                        page.PageInfo.Margin.Top = (0);
                                        page.PageInfo.Margin.Right = (0);
                                        page.PageInfo.Margin.Left = (0);
                                        page.Paragraphs.Add(asImg);

                                        imgDoc.Save(savepath);
                                        break;
                                    default:
                                        MessageBox.Show("this file type isn't supported to convert to pdf\n" +
                                            "we support these file type:\n" +
                                            ".doc, .docx, .jpg, .png",
                                            "error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex.Message);
                            }
                            break;
                        default:
                            MessageBox.Show("Not selected file type",
                                "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    if (File.Exists(savepath))
                        lbl_saved.Text = "saved as " + savepath;
                    else
                        lbl_saved.Text = "Convert error";

                    savepath = "";
                    cbx_image.Text = "";
                    cbx_audio.Text = "";
                    cbx_video.Text = "";
                    cbx_other.Text = "";
                }
            }
        }
    

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx_type = (ComboBox)sender;
            convertType = cbx_type.SelectedItem as string;
        }

        private string FFMEPG_RunProcess(string cmdPara)
        {
            var oInfo = new ProcessStartInfo(@"ffmpeg.exe", cmdPara);
            oInfo.UseShellExecute = false;
            oInfo.CreateNoWindow = true;
            oInfo.RedirectStandardOutput = true;
            oInfo.RedirectStandardError = true;
            oInfo.RedirectStandardInput = true;
            oInfo.StandardErrorEncoding = Encoding.UTF8;

            string output = null;
            StreamReader sr = null;

            try
            {
                var proc = Process.Start(oInfo);

                proc.WaitForExit();

                sr = proc.StandardError;
                output = sr.ReadToEnd();

                proc.Close();
            }
            catch(Exception) 
            {
                output = string.Empty;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
            return output;
        }

        private string FileCopy()
        {
            File.Copy(filepath, tempCopy + fileType, true);
            return tempCopy + fileType;
        }

        private void FileSave()
        {
            File.Copy(tempSave + convertType, savepath, true);
            File.Delete(tempCopy + fileType);
            File.Delete(tempSave + convertType);
        }

        private void lbx_ConvertedFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件 
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbx_ConvertedFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            filepath = filePaths[0];

            lbl_SelectedFile.Text = filepath;

            fileType = filepath.Split('.')[1];
            switch (fileType)
            {
                case "gif":
                case "GIF":
                case "bmp":
                case "BMP":
                case "png":
                case "PNG":
                case "ico":
                case "ICO":
                case "jpg":
                case "JPG":
                case "jpeg":
                case "JPEG":
                    cbx_image.Enabled = true;
                    cbx_audio.Enabled = false;
                    cbx_video.Enabled = false;
                    cbx_other.Enabled = true;
                    break;
                case "mp3":
                case "MP3":
                case "wav":
                case "WAV":
                    cbx_image.Enabled = false;
                    cbx_audio.Enabled = true;
                    cbx_video.Enabled = false;
                    cbx_other.Enabled = false;
                    break;
                case "avi":
                case "AVI":
                case "mp4":
                case "MP4":
                case "mov":
                case "MOV":
                case "wmv":
                case "WMV":
                case "flv":
                case "FLV":
                    cbx_image.Enabled = false;
                    cbx_audio.Enabled = true;
                    cbx_video.Enabled = true;
                    cbx_other.Enabled = false;
                    break;
                default:
                    cbx_image.Enabled = false;
                    cbx_audio.Enabled = false;
                    cbx_video.Enabled = false;
                    cbx_other.Enabled = true;
                    break;
            }

            lbl_saved.Text = "";

            Icon icon = Icon.ExtractAssociatedIcon(filepath);
            Bitmap b = icon.ToBitmap();
            Image icon_image = ResizeImage(b, new Size(pbx_ConvertFile.Width, pbx_ConvertFile.Height));
            pbx_ConvertFile.Image = icon_image;
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(b);

            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            g.Dispose();
            return (Image)b;
        }
    }
}
