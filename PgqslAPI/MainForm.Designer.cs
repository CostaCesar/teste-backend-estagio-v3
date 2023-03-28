
namespace PgsqlAPI
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button_CurrentState = new System.Windows.Forms.Button();
            this.Button_CurrentPos = new System.Windows.Forms.Button();
            this.MainList = new System.Windows.Forms.ListBox();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.equipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_menu = new System.Windows.Forms.Label();
            this.label_show = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_CurrentState
            // 
            this.Button_CurrentState.Location = new System.Drawing.Point(12, 326);
            this.Button_CurrentState.Name = "Button_CurrentState";
            this.Button_CurrentState.Size = new System.Drawing.Size(150, 25);
            this.Button_CurrentState.TabIndex = 0;
            this.Button_CurrentState.Text = "Estados atuais";
            this.Button_CurrentState.UseVisualStyleBackColor = true;
            // 
            // Button_CurrentPos
            // 
            this.Button_CurrentPos.Location = new System.Drawing.Point(12, 295);
            this.Button_CurrentPos.Name = "Button_CurrentPos";
            this.Button_CurrentPos.Size = new System.Drawing.Size(150, 25);
            this.Button_CurrentPos.TabIndex = 1;
            this.Button_CurrentPos.Text = "Posições atuais";
            this.Button_CurrentPos.UseVisualStyleBackColor = true;
            // 
            // MainList
            // 
            this.MainList.FormattingEnabled = true;
            this.MainList.Items.AddRange(new object[] {
            "Elem1",
            "Elem2"});
            this.MainList.Location = new System.Drawing.Point(168, 39);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(404, 316);
            this.MainList.TabIndex = 3;
            this.MainList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainList_MouseDown);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Location = new System.Drawing.Point(12, 39);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(150, 25);
            this.Button_Refresh.TabIndex = 4;
            this.Button_Refresh.Text = "Atualizar";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(110, 92);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoToolStripMenuItem,
            this.posiçãoToolStripMenuItem,
            this.balançoToolStripMenuItem,
            this.aToolStripMenuItem,
            this.equipamentoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.estadoToolStripMenuItem.Text = "Estado";
            // 
            // posiçãoToolStripMenuItem
            // 
            this.posiçãoToolStripMenuItem.Name = "posiçãoToolStripMenuItem";
            this.posiçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.posiçãoToolStripMenuItem.Text = "Posição";
            // 
            // balançoToolStripMenuItem
            // 
            this.balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            this.balançoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.balançoToolStripMenuItem.Text = "Balanço";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(142, 6);
            // 
            // equipamentoToolStripMenuItem
            // 
            this.equipamentoToolStripMenuItem.Name = "equipamentoToolStripMenuItem";
            this.equipamentoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.equipamentoToolStripMenuItem.Text = "Equipamento";
            this.equipamentoToolStripMenuItem.Click += new System.EventHandler(this.equipamentoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem1,
            this.posiçõesToolStripMenuItem,
            this.ganhosToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // geralToolStripMenuItem1
            // 
            this.geralToolStripMenuItem1.Name = "geralToolStripMenuItem1";
            this.geralToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.geralToolStripMenuItem1.Text = "Geral";
            // 
            // posiçõesToolStripMenuItem
            // 
            this.posiçõesToolStripMenuItem.Name = "posiçõesToolStripMenuItem";
            this.posiçõesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.posiçõesToolStripMenuItem.Text = "Posições";
            // 
            // ganhosToolStripMenuItem
            // 
            this.ganhosToolStripMenuItem.Name = "ganhosToolStripMenuItem";
            this.ganhosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ganhosToolStripMenuItem.Text = "Ganhos";
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.estadosToolStripMenuItem.Text = "Estados";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem,
            this.atividadeToolStripMenuItem,
            this.localizaçãoToolStripMenuItem,
            this.ganhoToolStripMenuItem});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            // 
            // atividadeToolStripMenuItem
            // 
            this.atividadeToolStripMenuItem.Name = "atividadeToolStripMenuItem";
            this.atividadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.atividadeToolStripMenuItem.Text = "Atividade";
            // 
            // localizaçãoToolStripMenuItem
            // 
            this.localizaçãoToolStripMenuItem.Name = "localizaçãoToolStripMenuItem";
            this.localizaçãoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.localizaçãoToolStripMenuItem.Text = "Localização";
            // 
            // ganhoToolStripMenuItem
            // 
            this.ganhoToolStripMenuItem.Name = "ganhoToolStripMenuItem";
            this.ganhoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ganhoToolStripMenuItem.Text = "Ganho";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipamentoToolStripMenuItem1,
            this.modeloToolStripMenuItem});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // equipamentoToolStripMenuItem1
            // 
            this.equipamentoToolStripMenuItem1.Name = "equipamentoToolStripMenuItem1";
            this.equipamentoToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.equipamentoToolStripMenuItem1.Text = "Equipamento";
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(31, 9);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(112, 20);
            this.label_menu.TabIndex = 7;
            this.label_menu.Text = "Equipamentos";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show.Location = new System.Drawing.Point(12, 265);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(46, 17);
            this.label_show.TabIndex = 9;
            this.label_show.Text = "Exibir:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label_show);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.Button_CurrentPos);
            this.Controls.Add(this.Button_CurrentState);
            this.Name = "MainForm";
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_CurrentState;
        private System.Windows.Forms.Button Button_CurrentPos;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem posiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
    }
}

