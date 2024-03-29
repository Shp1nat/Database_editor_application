namespace _3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.knigi = new System.Windows.Forms.Button();
            this.avtor = new System.Windows.Forms.Button();
            this.filial = new System.Windows.Forms.Button();
            this.idKnigi = new System.Windows.Forms.ListBox();
            this.Nazvanie = new System.Windows.Forms.ListBox();
            this.avtor_knigi = new System.Windows.Forms.ListBox();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.newNazvanie = new System.Windows.Forms.TextBox();
            this.newAvtor = new System.Windows.Forms.TextBox();
            this.imya = new System.Windows.Forms.ListBox();
            this.familiya = new System.Windows.Forms.ListBox();
            this.otchestvo = new System.Windows.Forms.ListBox();
            this.idAvtor = new System.Windows.Forms.ListBox();
            this.addImya = new System.Windows.Forms.TextBox();
            this.addFamiliya = new System.Windows.Forms.TextBox();
            this.addOtchestvo = new System.Windows.Forms.TextBox();
            this.gorod = new System.Windows.Forms.ListBox();
            this.ylica = new System.Windows.Forms.ListBox();
            this.nomerDoma = new System.Windows.Forms.ListBox();
            this.idFiliala = new System.Windows.Forms.ListBox();
            this.addGorod = new System.Windows.Forms.TextBox();
            this.addYlica = new System.Windows.Forms.TextBox();
            this.addNomerDoma = new System.Windows.Forms.TextBox();
            this.dost_ekzemplyari = new System.Windows.Forms.ListBox();
            this.newDE = new System.Windows.Forms.TextBox();
            this.iddd = new System.Windows.Forms.Label();
            this.LBavtor = new System.Windows.Forms.Label();
            this.LBnazvanie = new System.Windows.Forms.Label();
            this.LBde = new System.Windows.Forms.Label();
            this.LBimya = new System.Windows.Forms.Label();
            this.LBfamiliya = new System.Windows.Forms.Label();
            this.LBotchestvo = new System.Windows.Forms.Label();
            this.LBgorod = new System.Windows.Forms.Label();
            this.LBylica = new System.Windows.Forms.Label();
            this.LBdom = new System.Windows.Forms.Label();
            this.idd = new System.Windows.Forms.Label();
            this.deleteByInd = new System.Windows.Forms.TextBox();
            this.deleteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // knigi
            // 
            this.knigi.Location = new System.Drawing.Point(1151, 545);
            this.knigi.Name = "knigi";
            this.knigi.Size = new System.Drawing.Size(75, 23);
            this.knigi.TabIndex = 0;
            this.knigi.Text = "книги";
            this.knigi.UseVisualStyleBackColor = true;
            this.knigi.Click += new System.EventHandler(this.knigi_Click);
            // 
            // avtor
            // 
            this.avtor.Location = new System.Drawing.Point(1232, 545);
            this.avtor.Name = "avtor";
            this.avtor.Size = new System.Drawing.Size(75, 23);
            this.avtor.TabIndex = 1;
            this.avtor.Text = "автор";
            this.avtor.UseVisualStyleBackColor = true;
            this.avtor.Click += new System.EventHandler(this.avtor_Click);
            // 
            // filial
            // 
            this.filial.Location = new System.Drawing.Point(1313, 545);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(75, 23);
            this.filial.TabIndex = 2;
            this.filial.Text = "филиал";
            this.filial.UseVisualStyleBackColor = true;
            this.filial.Click += new System.EventHandler(this.filial_Click);
            // 
            // idKnigi
            // 
            this.idKnigi.FormattingEnabled = true;
            this.idKnigi.Location = new System.Drawing.Point(33, 119);
            this.idKnigi.Name = "idKnigi";
            this.idKnigi.Size = new System.Drawing.Size(47, 212);
            this.idKnigi.TabIndex = 3;
            this.idKnigi.Visible = false;
            // 
            // Nazvanie
            // 
            this.Nazvanie.FormattingEnabled = true;
            this.Nazvanie.Location = new System.Drawing.Point(104, 119);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(199, 212);
            this.Nazvanie.TabIndex = 4;
            this.Nazvanie.Visible = false;
            // 
            // avtor_knigi
            // 
            this.avtor_knigi.FormattingEnabled = true;
            this.avtor_knigi.Location = new System.Drawing.Point(343, 119);
            this.avtor_knigi.Name = "avtor_knigi";
            this.avtor_knigi.Size = new System.Drawing.Size(120, 212);
            this.avtor_knigi.TabIndex = 5;
            this.avtor_knigi.Visible = false;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(847, 94);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 6;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(688, 94);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // newNazvanie
            // 
            this.newNazvanie.Location = new System.Drawing.Point(104, 81);
            this.newNazvanie.Name = "newNazvanie";
            this.newNazvanie.Size = new System.Drawing.Size(199, 20);
            this.newNazvanie.TabIndex = 8;
            this.newNazvanie.Visible = false;
            // 
            // newAvtor
            // 
            this.newAvtor.Location = new System.Drawing.Point(343, 81);
            this.newAvtor.Name = "newAvtor";
            this.newAvtor.Size = new System.Drawing.Size(120, 20);
            this.newAvtor.TabIndex = 9;
            this.newAvtor.Visible = false;
            // 
            // imya
            // 
            this.imya.FormattingEnabled = true;
            this.imya.Location = new System.Drawing.Point(104, 119);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(120, 212);
            this.imya.TabIndex = 10;
            this.imya.Visible = false;
            // 
            // familiya
            // 
            this.familiya.FormattingEnabled = true;
            this.familiya.Location = new System.Drawing.Point(264, 119);
            this.familiya.Name = "familiya";
            this.familiya.Size = new System.Drawing.Size(120, 212);
            this.familiya.TabIndex = 11;
            this.familiya.Visible = false;
            // 
            // otchestvo
            // 
            this.otchestvo.FormattingEnabled = true;
            this.otchestvo.Location = new System.Drawing.Point(429, 119);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(120, 212);
            this.otchestvo.TabIndex = 12;
            this.otchestvo.Visible = false;
            // 
            // idAvtor
            // 
            this.idAvtor.FormattingEnabled = true;
            this.idAvtor.Location = new System.Drawing.Point(33, 119);
            this.idAvtor.Name = "idAvtor";
            this.idAvtor.Size = new System.Drawing.Size(47, 212);
            this.idAvtor.TabIndex = 13;
            this.idAvtor.Visible = false;
            // 
            // addImya
            // 
            this.addImya.Location = new System.Drawing.Point(104, 81);
            this.addImya.Name = "addImya";
            this.addImya.Size = new System.Drawing.Size(120, 20);
            this.addImya.TabIndex = 14;
            this.addImya.Visible = false;
            // 
            // addFamiliya
            // 
            this.addFamiliya.Location = new System.Drawing.Point(264, 81);
            this.addFamiliya.Name = "addFamiliya";
            this.addFamiliya.Size = new System.Drawing.Size(120, 20);
            this.addFamiliya.TabIndex = 15;
            this.addFamiliya.Visible = false;
            // 
            // addOtchestvo
            // 
            this.addOtchestvo.Location = new System.Drawing.Point(429, 81);
            this.addOtchestvo.Name = "addOtchestvo";
            this.addOtchestvo.Size = new System.Drawing.Size(120, 20);
            this.addOtchestvo.TabIndex = 16;
            this.addOtchestvo.Visible = false;
            // 
            // gorod
            // 
            this.gorod.FormattingEnabled = true;
            this.gorod.Location = new System.Drawing.Point(104, 119);
            this.gorod.Name = "gorod";
            this.gorod.Size = new System.Drawing.Size(120, 212);
            this.gorod.TabIndex = 17;
            this.gorod.Visible = false;
            // 
            // ylica
            // 
            this.ylica.FormattingEnabled = true;
            this.ylica.Location = new System.Drawing.Point(264, 119);
            this.ylica.Name = "ylica";
            this.ylica.Size = new System.Drawing.Size(120, 212);
            this.ylica.TabIndex = 18;
            this.ylica.Visible = false;
            // 
            // nomerDoma
            // 
            this.nomerDoma.FormattingEnabled = true;
            this.nomerDoma.Location = new System.Drawing.Point(429, 119);
            this.nomerDoma.Name = "nomerDoma";
            this.nomerDoma.Size = new System.Drawing.Size(120, 212);
            this.nomerDoma.TabIndex = 19;
            this.nomerDoma.Visible = false;
            // 
            // idFiliala
            // 
            this.idFiliala.FormattingEnabled = true;
            this.idFiliala.Location = new System.Drawing.Point(33, 119);
            this.idFiliala.Name = "idFiliala";
            this.idFiliala.Size = new System.Drawing.Size(47, 212);
            this.idFiliala.TabIndex = 20;
            this.idFiliala.Visible = false;
            // 
            // addGorod
            // 
            this.addGorod.Location = new System.Drawing.Point(104, 93);
            this.addGorod.Name = "addGorod";
            this.addGorod.Size = new System.Drawing.Size(120, 20);
            this.addGorod.TabIndex = 21;
            this.addGorod.Visible = false;
            // 
            // addYlica
            // 
            this.addYlica.Location = new System.Drawing.Point(264, 93);
            this.addYlica.Name = "addYlica";
            this.addYlica.Size = new System.Drawing.Size(120, 20);
            this.addYlica.TabIndex = 22;
            this.addYlica.Visible = false;
            // 
            // addNomerDoma
            // 
            this.addNomerDoma.Location = new System.Drawing.Point(429, 93);
            this.addNomerDoma.Name = "addNomerDoma";
            this.addNomerDoma.Size = new System.Drawing.Size(120, 20);
            this.addNomerDoma.TabIndex = 23;
            this.addNomerDoma.Visible = false;
            // 
            // dost_ekzemplyari
            // 
            this.dost_ekzemplyari.FormattingEnabled = true;
            this.dost_ekzemplyari.Location = new System.Drawing.Point(480, 119);
            this.dost_ekzemplyari.Name = "dost_ekzemplyari";
            this.dost_ekzemplyari.Size = new System.Drawing.Size(138, 212);
            this.dost_ekzemplyari.TabIndex = 24;
            this.dost_ekzemplyari.Visible = false;
            // 
            // newDE
            // 
            this.newDE.Location = new System.Drawing.Point(480, 81);
            this.newDE.Name = "newDE";
            this.newDE.Size = new System.Drawing.Size(120, 20);
            this.newDE.TabIndex = 25;
            this.newDE.Visible = false;
            // 
            // iddd
            // 
            this.iddd.AutoSize = true;
            this.iddd.Location = new System.Drawing.Point(47, 99);
            this.iddd.Name = "iddd";
            this.iddd.Size = new System.Drawing.Size(15, 13);
            this.iddd.TabIndex = 26;
            this.iddd.Text = "id";
            this.iddd.Visible = false;
            // 
            // LBavtor
            // 
            this.LBavtor.AutoSize = true;
            this.LBavtor.Location = new System.Drawing.Point(142, 65);
            this.LBavtor.Name = "LBavtor";
            this.LBavtor.Size = new System.Drawing.Size(37, 13);
            this.LBavtor.TabIndex = 27;
            this.LBavtor.Text = "Автор";
            this.LBavtor.Visible = false;
            // 
            // LBnazvanie
            // 
            this.LBnazvanie.AutoSize = true;
            this.LBnazvanie.Location = new System.Drawing.Point(340, 65);
            this.LBnazvanie.Name = "LBnazvanie";
            this.LBnazvanie.Size = new System.Drawing.Size(57, 13);
            this.LBnazvanie.TabIndex = 28;
            this.LBnazvanie.Text = "Название";
            this.LBnazvanie.Visible = false;
            // 
            // LBde
            // 
            this.LBde.AutoSize = true;
            this.LBde.Location = new System.Drawing.Point(477, 65);
            this.LBde.Name = "LBde";
            this.LBde.Size = new System.Drawing.Size(131, 13);
            this.LBde.TabIndex = 29;
            this.LBde.Text = "Доступные экземпляры";
            this.LBde.Visible = false;
            // 
            // LBimya
            // 
            this.LBimya.AutoSize = true;
            this.LBimya.Location = new System.Drawing.Point(122, 65);
            this.LBimya.Name = "LBimya";
            this.LBimya.Size = new System.Drawing.Size(29, 13);
            this.LBimya.TabIndex = 30;
            this.LBimya.Text = "Имя";
            this.LBimya.Visible = false;
            // 
            // LBfamiliya
            // 
            this.LBfamiliya.AutoSize = true;
            this.LBfamiliya.Location = new System.Drawing.Point(278, 65);
            this.LBfamiliya.Name = "LBfamiliya";
            this.LBfamiliya.Size = new System.Drawing.Size(56, 13);
            this.LBfamiliya.TabIndex = 31;
            this.LBfamiliya.Text = "Фамилия";
            this.LBfamiliya.Visible = false;
            // 
            // LBotchestvo
            // 
            this.LBotchestvo.AutoSize = true;
            this.LBotchestvo.Location = new System.Drawing.Point(458, 65);
            this.LBotchestvo.Name = "LBotchestvo";
            this.LBotchestvo.Size = new System.Drawing.Size(54, 13);
            this.LBotchestvo.TabIndex = 32;
            this.LBotchestvo.Text = "Отчество";
            this.LBotchestvo.Visible = false;
            // 
            // LBgorod
            // 
            this.LBgorod.AutoSize = true;
            this.LBgorod.Location = new System.Drawing.Point(125, 65);
            this.LBgorod.Name = "LBgorod";
            this.LBgorod.Size = new System.Drawing.Size(37, 13);
            this.LBgorod.TabIndex = 33;
            this.LBgorod.Text = "Город";
            this.LBgorod.Visible = false;
            // 
            // LBylica
            // 
            this.LBylica.AutoSize = true;
            this.LBylica.Location = new System.Drawing.Point(295, 65);
            this.LBylica.Name = "LBylica";
            this.LBylica.Size = new System.Drawing.Size(39, 13);
            this.LBylica.TabIndex = 34;
            this.LBylica.Text = "Улица";
            this.LBylica.Visible = false;
            // 
            // LBdom
            // 
            this.LBdom.AutoSize = true;
            this.LBdom.Location = new System.Drawing.Point(477, 65);
            this.LBdom.Name = "LBdom";
            this.LBdom.Size = new System.Drawing.Size(30, 13);
            this.LBdom.TabIndex = 35;
            this.LBdom.Text = "Дом";
            this.LBdom.Visible = false;
            // 
            // idd
            // 
            this.idd.AutoSize = true;
            this.idd.Location = new System.Drawing.Point(789, 214);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(15, 13);
            this.idd.TabIndex = 36;
            this.idd.Text = "id";
            this.idd.Visible = false;
            // 
            // deleteByInd
            // 
            this.deleteByInd.Location = new System.Drawing.Point(772, 230);
            this.deleteByInd.Name = "deleteByInd";
            this.deleteByInd.Size = new System.Drawing.Size(50, 20);
            this.deleteByInd.TabIndex = 37;
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(761, 256);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(75, 23);
            this.deleteBut.TabIndex = 38;
            this.deleteBut.Text = "Удалить";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 603);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.deleteByInd);
            this.Controls.Add(this.idd);
            this.Controls.Add(this.LBdom);
            this.Controls.Add(this.LBylica);
            this.Controls.Add(this.LBgorod);
            this.Controls.Add(this.LBotchestvo);
            this.Controls.Add(this.LBfamiliya);
            this.Controls.Add(this.LBimya);
            this.Controls.Add(this.LBde);
            this.Controls.Add(this.LBnazvanie);
            this.Controls.Add(this.LBavtor);
            this.Controls.Add(this.iddd);
            this.Controls.Add(this.newDE);
            this.Controls.Add(this.dost_ekzemplyari);
            this.Controls.Add(this.addNomerDoma);
            this.Controls.Add(this.addYlica);
            this.Controls.Add(this.addGorod);
            this.Controls.Add(this.idFiliala);
            this.Controls.Add(this.nomerDoma);
            this.Controls.Add(this.ylica);
            this.Controls.Add(this.gorod);
            this.Controls.Add(this.addOtchestvo);
            this.Controls.Add(this.addFamiliya);
            this.Controls.Add(this.addImya);
            this.Controls.Add(this.idAvtor);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.familiya);
            this.Controls.Add(this.imya);
            this.Controls.Add(this.newAvtor);
            this.Controls.Add(this.newNazvanie);
            this.Controls.Add(this.add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.avtor_knigi);
            this.Controls.Add(this.Nazvanie);
            this.Controls.Add(this.idKnigi);
            this.Controls.Add(this.filial);
            this.Controls.Add(this.avtor);
            this.Controls.Add(this.knigi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knigi;
        private System.Windows.Forms.Button avtor;
        private System.Windows.Forms.Button filial;
        private System.Windows.Forms.ListBox idKnigi;
        private System.Windows.Forms.ListBox Nazvanie;
        private System.Windows.Forms.ListBox avtor_knigi;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox newNazvanie;
        private System.Windows.Forms.TextBox newAvtor;
        private System.Windows.Forms.ListBox imya;
        private System.Windows.Forms.ListBox familiya;
        private System.Windows.Forms.ListBox otchestvo;
        private System.Windows.Forms.ListBox idAvtor;
        private System.Windows.Forms.TextBox addImya;
        private System.Windows.Forms.TextBox addFamiliya;
        private System.Windows.Forms.TextBox addOtchestvo;
        private System.Windows.Forms.ListBox gorod;
        private System.Windows.Forms.ListBox ylica;
        private System.Windows.Forms.ListBox nomerDoma;
        private System.Windows.Forms.ListBox idFiliala;
        private System.Windows.Forms.TextBox addGorod;
        private System.Windows.Forms.TextBox addYlica;
        private System.Windows.Forms.TextBox addNomerDoma;
        private System.Windows.Forms.ListBox dost_ekzemplyari;
        private System.Windows.Forms.TextBox newDE;
        private System.Windows.Forms.Label iddd;
        private System.Windows.Forms.Label LBavtor;
        private System.Windows.Forms.Label LBnazvanie;
        private System.Windows.Forms.Label LBde;
        private System.Windows.Forms.Label LBimya;
        private System.Windows.Forms.Label LBfamiliya;
        private System.Windows.Forms.Label LBotchestvo;
        private System.Windows.Forms.Label LBgorod;
        private System.Windows.Forms.Label LBylica;
        private System.Windows.Forms.Label LBdom;
        private System.Windows.Forms.Label idd;
        private System.Windows.Forms.TextBox deleteByInd;
        private System.Windows.Forms.Button deleteBut;
    }
}

