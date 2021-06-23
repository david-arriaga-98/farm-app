namespace CapaDePresentacion.PanelPrincipal
{
    partial class Informacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manual de Usuario";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "1.En el login del programa procedemos a poner el usuario y el password.",
            "",
            "2.La pantalla de presentación del programa tenemos la opción de entrar al menú ",
            "o salir de programa.",
            "",
            "3.menú tenemos las opciones que podemos realizar en el programa: Ingresar, ",
            "Iniciar progresos, Consultar información, Editar Información y ver información ",
            "de un nuestra empresa.",
            "",
            "4.Ingreso de Hectarea, podemos ingresar el numero de lotes, el nombre de lotes ",
            "y el tamaño de la hectaria. ",
            "",
            "5.Ingreso de Lote, escogemos la hectárea que acabamos de llenar y le asignamos ",
            "un nombre.",
            "",
            "6.Ingreso de Sembríos, nos genera un código que diferenciara a cada sembrío",
            "y escogemos la época en que va iniciar el sembrío, que producto se va a cosechar " +
                "",
            "y la duración del sembrío.",
            "",
            "7.Ingreso de sensores escogemos el tipo de sensor que se va utilizar.",
            "",
            "8.Inicio de sembrío escogemos la hectárea que acabamos de ingresar con su ",
            "respectivo lote y producto a sembrar.",
            "",
            "9.Consulta de sembrio permite consultar la información del tipo de sembrío que",
            " acabamos de llenar.",
            "",
            "10.Consulta de hectarea nos permite consultar la información del tipo de hectárea" +
                "",
            "que acabamos de llenar.",
            "",
            "11.Regar Sembrio nos permite consultar la información de los sembríos iniciados",
            "que acabamos de llenar.",
            "",
            "12.Consulta de sensores nos permite saber que sensores están trabajando en cada",
            "sembrío",
            "",
            "13.Consulta de historial nos permite observar todo el historial que hemos realiza" +
                "do",
            " en el programa.",
            "",
            "14.Finalizar cultivo podemos editar información que queramos corregir.",
            "",
            "15. Informavion nos permite observar información del programa",
            "",
            "16.Servicio al cliente es para que el cliente tenga conocimiento en donde puede ",
            "comunicar sus reclamos."});
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 319);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(608, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Informacion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}