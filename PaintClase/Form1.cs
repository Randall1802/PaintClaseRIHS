using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PaintClase
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int anchoPluma; //track bar value =3
        //int x = 0, y = 0;
        bool moving;
        Pen pen;
        int r = 0;
        int g = 0;
        int b = 0;
        bool pintar = false;
        bool borrar = false;
        SolidBrush myBrush;
        Point px, py;
        int selec;
        int xx, yy, sX, sY, cX, cY;
        Bitmap bm;

        public Form1()
        {
            InitializeComponent();
            //asignamos graphics al pb
            bm = new Bitmap(txtPapel.Width, txtPapel.Height);
            //papel = txtPapel.CreateGraphics();
            papel = Graphics.FromImage(bm);
            papel.Clear(Color.White);
            txtPapel.Image = bm;
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //suavizar cuando se dibuje en el pB
            //inicializamos variable con el valor del tbar
            anchoPluma = trackBar1.Value;
            //inicializando el rgb con los valores del tbox
            r = int.Parse(txtR.Text);
            g = int.Parse(txtG.Text);
            b = int.Parse(txtB.Text);
            //inicializamos un pincel con los colores y el tamaño del pincel
            pen = new Pen(Color.FromArgb(r, g, b), anchoPluma);
            //inicio y final de la pluma terminan en círculo
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        //evento q se dispara al hacer clic y sostenerlo en el pbox
        private void txtPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            //x = e.X; y = e.Y;
            //establecemos el valor inicial del mouse en py
            py = e.Location;
            //en cx y cy, establecemos los valores de las coordenadas en x y en y
            cX = e.X;
            cY = e.Y;
            txtPapel.Cursor = Cursors.Cross;
        }
        //evento q se dispara cuando movemos el cursor sobre el pb
        private void txtPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && pintar)
            {
                //llamamos función para cambiar las propiedades del pincel
                cambiarValoresPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                //dibujamos una línea posición actual hacia donde nos movemos
                if (selec == 1)
                {
                    //a px le asignamos el valor del evento del mouse y lo igualamos con py
                    //para que vaya dibujando una línea libre según movamos el mouse
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                    //x = e.X; y = e.Y;
                }
            }
            if (moving && borrar)
            {
                selec = 0;
                cambiarValoresPluma(255, 255, 255);
                papel.DrawLine(pen, new Point(xx, yy), e.Location);
                xx = e.X; yy = e.Y;
            }
            //refrescamos el picture box para que se vaya actualizando el contenido y se 
            //dibujen en tiempo real las figuras
            txtPapel.Refresh();
            xx = e.X;
            yy = e.Y;
            //Sx y sy serán las coordenadas finales de la línea
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        //evento q se dispara al dejar de hacer clic sostenido sobre el pbox
        private void txtPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            //sx y sy tendrán el valor de las coordenadas finales al dejar de hacer clic sostenido en el
            //picture box 
            sX = xx - cX;
            sY = yy - cY;
            //la variable selec establece qué figura se dibujará en tiempo real según se haga clic al botón 
            //que corresponda
            if (selec == 2)
            {
                papel.DrawLine(pen, cX, cY, xx, yy);
            }
            if (selec == 3)
            {
                papel.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (selec == 4)
            {
                papel.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (selec == 5)
            {
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(r, g, b));
                papel.FillEllipse(myBrush, new Rectangle(cX, cY, sX, sY));
            }
        }
        //evento q ocurre al desplazar el trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //le pasamos el valor actual del trackb a la variable
            anchoPluma = trackBar1.Value;
            //modificamos el label con el valor del tbar
            lblTP.Text = trackBar1.Value.ToString();
        }

        private void cambiarValoresPluma(int r, int g, int b)
        {
            pen = new Pen(Color.FromArgb(r, g, b), anchoPluma);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        //evento q ocurre al hacer clic al boton pintar
        private void btnPintar_Click(object sender, EventArgs e)
        {
            //el selec 1 es para dibujar en estilo libre
            selec = 1;
            pintar = true;
            borrar = false;
        }
        //evento q ocurre al hacer clic al btn borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
        }
        //pb para pasar a color black el pincel
        private void pbB_Click(object sender, EventArgs e)
        {
            txtR.Text = txtG.Text = txtB.Text = 0.ToString();
        }
        //pb q muestra el colordialog
        private void pbC_Click(object sender, EventArgs e)
        {
            //mostramos el color dialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //asignar a los tbox el color seleccionado
                r = colorDialog1.Color.R;
                g = colorDialog1.Color.G;
                b = colorDialog1.Color.B;
                txtR.Text = r.ToString();
                txtG.Text = g.ToString();
                txtB.Text = b.ToString();
            }
        }

        private void btnDib_Click(object sender, EventArgs e)
        {
            //papel.Clear(Color.White);
            cambiarValoresPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
            //según el check box seleccionado y el clic al botón dibujar, se dibujará la figura 
            if (rbLinea.Checked)
            {
                papel.DrawLine(pen, 300, 90, 400, 90);
            }
            if (rbCua.Checked)
            {
                papel.DrawRectangle(pen, 300, 150, 100, 100);
            }
            if (rbRec.Checked)
            {
                papel.DrawRectangle(pen, 10, 10, 100, 50);
            }
            if (rbElipse.Checked)
            {
                papel.DrawEllipse(pen, 220, 50, 70, 70);
            }
            if (rbER.Checked)
            {
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(r, g, b));
                papel.FillEllipse(myBrush, new Rectangle(410, 50, 70, 70));
            }
            txtPapel.Refresh();
        }

        //si se hace clic en uno de estos botones, se podrá dibujar esa figura en tiempo real
        private void Linea_Click(object sender, EventArgs e)
        {
            selec = 2;
        }

        private void Rec_Click(object sender, EventArgs e)
        {
            selec = 3;
        }

        private void Eli_Click(object sender, EventArgs e)
        {
            selec = 4;
        }

        private void ERellena_Click(object sender, EventArgs e)
        {
            selec = 5;
        }

        //evento que se dispara al dibujar sobre el picture box
        private void txtPapel_Paint(object sender, PaintEventArgs e)
        {
            //a papel le asignamos el valor de los eventos que ocurren al dibujar
            Graphics papel = e.Graphics;
            //esto es para que al arrastrar el mouse al dibujar se vaya actualizando en tiempo real
            if (moving == true)
            {
                if (selec == 2)
                {
                    papel.DrawLine(pen, cX, cY, xx, yy);
                }
                if (selec == 3)
                {
                    papel.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (selec == 4)
                {
                    papel.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (selec == 5)
                {
                    myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(r, g, b));
                    papel.FillEllipse(myBrush, new Rectangle(cX, cY, sX, sY));
                }
            }
        }
        //botón para guardar dibujo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creamos una instancia de un save file dialog
            var sfd = new SaveFileDialog();
            //Filtramos los formatos de imagen que pueden usarse
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ya que vamos actualizando el picture box en un bitmap bm, lo copiamos a
                //una variable nueva para que se guarde y así al darle clic al guardar, se guarde como
                //formato jpeg
                Bitmap btm = bm.Clone(new Rectangle(0, 0, txtPapel.Width, txtPapel.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}