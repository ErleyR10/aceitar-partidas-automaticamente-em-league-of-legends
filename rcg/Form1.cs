
using System.Drawing.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;
using WindowsInput;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace LoLAceept

{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

     
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        

        private NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.MaximumSize = this.Size;
            btnaltaresoluçao.Checked = true;

            this.ShowInTaskbar = false;
        
            this.Resize += Form1_Resize;
            
            this.Icon = Properties.Resources.icone;


            InitializeTrayIcon();

        }

        private void InitializeTrayIcon()
        {
            notifyIcon = new NotifyIcon();

            notifyIcon.Icon = Properties.Resources.icone;

            notifyIcon.Click += notifyIcon1_DoubleClick;
          

            notifyIcon.Visible = true;

        }

        private async void checkativar_CheckedChanged(object sender, EventArgs e)

        {

            if (radioativar.Checked)
            {
                
                radiodesativar.Checked = false;
                checkBox1.Checked = false;
                await Task.Run(() => RepetirAcoes());
                radioativar.Checked = false; 
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide(); 
            }
        }


        public void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
           
            Show();
            WindowState = FormWindowState.Normal;
                   
            Activate();
            Focus();
        }

        static Bitmap ConvertToSupportedFormat(Bitmap image)
        {
            Bitmap convertedImage = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(convertedImage))
            {
                g.DrawImage(image, 0, 0);
            }
            return convertedImage;
        }

        public Bitmap CaptureScreen()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(screenBounds.Left, screenBounds.Top, 0, 0, screenBounds.Size, CopyPixelOperation.SourceCopy);
                ResizeImage(screenshot, 800, 600);
            }
            return screenshot;
        }

        Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void Email(object sender, EventArgs e)
        {

        }

        public void checkdesativar(object sender, EventArgs e)
        {
            if (radiodesativar.Checked == true)
            {

                radioativar.Checked = false;
                checkBox1.Checked = false;

            }
        }

        public void RepetirAcoes()
        {
            int numerodevezes = 0;
            int tempo = 0;

            {

                while (radioativar.Checked == true && radiodesativar.Checked == false || checkBox1.Checked == true)

                {
                    Bitmap imageToFind = new Bitmap(Properties.Resources.aceitar06);

                    if (btnbaixaresoluçao.Checked == true)
                    {
                        imageToFind = (Properties.Resources.aceitar1);

                    }

                    imageToFind = ConvertToSupportedFormat(imageToFind);

                    // Capturar uma screenshot da tela
                    Bitmap desktopScreenshot = CaptureScreen();
                    desktopScreenshot = ConvertToSupportedFormat(desktopScreenshot);

                    // Aplicar escala de cinza nas imagens
                    Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                    imageToFind = filter.Apply(imageToFind);
                    desktopScreenshot = filter.Apply(desktopScreenshot);

                    // Definir a área central para a busca da imagem
                    int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                    int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                    int centerX = screenWidth / 2;
                    int centerY = (screenHeight * 2) / 3; // Parte de baixo e centros

                    int searchAreaWidth = 500; // Largura da área de busca
                    int searchAreaHeight = 500; // Altura da área de busca

                    int searchAreaX = centerX - (searchAreaWidth / 2);
                    int searchAreaY = centerY - (searchAreaHeight / 2);

                    // Recortar a área de busca da screenshot
                    Rectangle searchAreaRect = new Rectangle(searchAreaX, searchAreaY, searchAreaWidth, searchAreaHeight);
                    Bitmap searchAreaImage = desktopScreenshot.Clone(searchAreaRect, desktopScreenshot.PixelFormat);

                    // Realizar a correspondência de template
                    ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.92f);//o funcional normal testado e 0.92
                    TemplateMatch[] matches = tm.ProcessImage(searchAreaImage, imageToFind);


                    if (matches.Length > 0)
                    {

                        Rectangle matchRect = matches[0].Rectangle;
                        
                        // Ajustar as coordenadas do retângulo correspondente para a área de busca
                        matchRect.Offset(searchAreaX, searchAreaY);

                        int imageX = matchRect.Left;
                        int imageY = matchRect.Top;
                        int imageWidth = matchRect.Width;
                        int imageHeight = matchRect.Height;

                        // Ajuste as coordenadas do clique para a resolução real da tela
                        int adjustedX = imageX * screenWidth / desktopScreenshot.Width;
                        int adjustedY = imageY * screenHeight / desktopScreenshot.Height;

                        // Calcule o centro da imagem ajustada
                        int clickX = adjustedX + (imageWidth / 2);
                        int clickY = adjustedY + (imageHeight / 2);

                        // Define a posição do cursor para o centro da imagem ajustada
                        Cursor.Position = new Point(clickX, clickY);

                        // Simule o clique do mouse físico usando a classe InputSimulator
                        InputSimulator simulator = new InputSimulator();                       

                        Cursor currentCursor = Cursor.Current;

                        // Definir o cursor como o cursor padrão de seta
                        Cursor.Current = Cursors.Default;

                        int click111 = clickX;
                        uint click11 = (uint)click111;

                        int click222 = clickY;
                        uint click22 = (uint)click222;

                        // Simule o clique do mouse usando a função mouse_event
                        mouse_event(MOUSEEVENTF_LEFTDOWN, click11, click22, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, click11, click22, 0, 0);

                        mouse_event(MOUSEEVENTF_LEFTDOWN, click11, click22, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, click11, click22, 0, 0);

                        Cursor.Position = new Point(clickX - 60, clickY + 90); ;

                        // Restaurar o cursor original
                        Cursor.Current = currentCursor;

                        Thread.Sleep(5000);
                        numerodevezes++;

                    }

                    else if (numerodevezes >= 1)

                    {
                        tempo++;

                    }

                     if (tempo == 25)  //20 que vai dar no final das contas 40000 milisegundos, ou seja, 40 segundos.

                       {

                        break;

                       }

                   imageToFind.Dispose();
                   desktopScreenshot.Dispose();
                   searchAreaImage.Dispose();

                   Thread.Sleep(2000);
                }
            }
        }

        private void btninstrucoes_Click(object sender, EventArgs e)
        {
            try
            {
               
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllText(tempFilePath, Properties.Resources.Instruçoes);            
                Process.Start("notepad.exe", tempFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o arquivo de texto: " + ex.Message);
            }
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
              
                radiodesativar.Checked = false;
                radioativar.Checked = false;

                while (checkBox1.Checked == true)
                {

                    await Task.Run(() => RepetirAcoes());

                    GC.Collect();

                }
            }
        }


        public void btnbaixaresoluçao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btaltaresoliçao(object sender, EventArgs e)
        {

        }
    }
}

//fim :)
