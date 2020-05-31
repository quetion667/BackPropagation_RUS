﻿using System.Windows.Forms;

namespace Backpropagation
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.progressionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.buttonParams = new System.Windows.Forms.Button();
            this.buttonTestSet = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.titleBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.panelTestSet = new System.Windows.Forms.Panel();
            this.savePanel = new System.Windows.Forms.Panel();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableClasses = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetSample = new System.Windows.Forms.Button();
            this.SaveTestSet = new System.Windows.Forms.Button();
            this.drawingBoard = new System.Windows.Forms.PictureBox();
            this.panelParam = new System.Windows.Forms.Panel();
            this.loadTestSet = new System.Windows.Forms.ComboBox();
            this.labelLoadTestSet = new System.Windows.Forms.Label();
            this.labelNumSymbolSamples = new System.Windows.Forms.Label();
            this.labelNumSamples = new System.Windows.Forms.Label();
            this.labelNumSymbols = new System.Windows.Forms.Label();
            this.numOfSymbolSamples = new System.Windows.Forms.ComboBox();
            this.numOfSamples = new System.Windows.Forms.ComboBox();
            this.numOfSymbols = new System.Windows.Forms.ComboBox();
            this.buttonLoadTestSet = new System.Windows.Forms.Button();
            this.labelOr = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.SetParameters = new System.Windows.Forms.Button();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.labelTotalError = new System.Windows.Forms.Label();
            this.labelTotalErrorStatic = new System.Windows.Forms.Label();
            this.buttonRemoveLayer = new System.Windows.Forms.Button();
            this.layoutArchitexture = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDesiredError = new System.Windows.Forms.TextBox();
            this.textBoxEta = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelDesiredError = new System.Windows.Forms.Label();
            this.labelEta = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAddLayer = new System.Windows.Forms.Button();
            this.labelArchitecture = new System.Windows.Forms.Label();
            this.errorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Train = new System.Windows.Forms.Button();
            this.GoToTest = new System.Windows.Forms.Button();
            this.panelTest = new System.Windows.Forms.Panel();
            this.resultClasses = new System.Windows.Forms.TableLayoutPanel();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelClassStatic = new System.Windows.Forms.Label();
            this.drawingBoardTest = new System.Windows.Forms.PictureBox();
            this.Test = new System.Windows.Forms.Button();
            this.progressionPanel.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.panelTestSet.SuspendLayout();
            this.savePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).BeginInit();
            this.panelParam.SuspendLayout();
            this.panelTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).BeginInit();
            this.panelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoardTest)).BeginInit();
            this.SuspendLayout();
            // 
            // progressionPanel
            // 
            this.progressionPanel.Controls.Add(this.panelIcon);
            this.progressionPanel.Controls.Add(this.buttonParams);
            this.progressionPanel.Controls.Add(this.buttonTestSet);
            this.progressionPanel.Controls.Add(this.buttonTrain);
            this.progressionPanel.Controls.Add(this.buttonTest);
            this.progressionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressionPanel.Location = new System.Drawing.Point(0, 0);
            this.progressionPanel.Name = "progressionPanel";
            this.progressionPanel.Size = new System.Drawing.Size(156, 600);
            this.progressionPanel.TabIndex = 2;
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::Backpropagation.Properties.Resources.NN;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Margin = new System.Windows.Forms.Padding(0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(159, 92);
            this.panelIcon.TabIndex = 0;
            // 
            // buttonParams
            // 
            this.buttonParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonParams.FlatAppearance.BorderSize = 0;
            this.buttonParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParams.Location = new System.Drawing.Point(0, 92);
            this.buttonParams.Margin = new System.Windows.Forms.Padding(0);
            this.buttonParams.Name = "buttonParams";
            this.buttonParams.Size = new System.Drawing.Size(156, 93);
            this.buttonParams.TabIndex = 1;
            this.buttonParams.Text = "Задание параметров";
            this.buttonParams.UseVisualStyleBackColor = true;
            this.buttonParams.Click += new System.EventHandler(this.ButtonParams_Click);
            // 
            // buttonTestSet
            // 
            this.buttonTestSet.Enabled = false;
            this.buttonTestSet.FlatAppearance.BorderSize = 0;
            this.buttonTestSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestSet.Location = new System.Drawing.Point(0, 185);
            this.buttonTestSet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTestSet.Name = "buttonTestSet";
            this.buttonTestSet.Size = new System.Drawing.Size(156, 93);
            this.buttonTestSet.TabIndex = 4;
            this.buttonTestSet.Text = "Ввод датасета";
            this.buttonTestSet.UseVisualStyleBackColor = true;
            this.buttonTestSet.Click += new System.EventHandler(this.ButtonTestSet_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Enabled = false;
            this.buttonTrain.FlatAppearance.BorderSize = 0;
            this.buttonTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrain.Location = new System.Drawing.Point(0, 278);
            this.buttonTrain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(156, 93);
            this.buttonTrain.TabIndex = 4;
            this.buttonTrain.Text = "Тренировка нейронной сети";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.ButtonTrain_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Enabled = false;
            this.buttonTest.FlatAppearance.BorderSize = 0;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Location = new System.Drawing.Point(0, 371);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(156, 93);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Тестировать нейронную сеть";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.buttonExit);
            this.titleBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(156, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(644, 32);
            this.titleBar.TabIndex = 3;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Backpropagation.Properties.Resources.Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(612, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelSlider.Location = new System.Drawing.Point(159, 92);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(10, 93);
            this.panelSlider.TabIndex = 4;
            // 
            // panelTestSet
            // 
            this.panelTestSet.Controls.Add(this.savePanel);
            this.panelTestSet.Controls.Add(this.tableClasses);
            this.panelTestSet.Controls.Add(this.buttonSetSample);
            this.panelTestSet.Controls.Add(this.SaveTestSet);
            this.panelTestSet.Controls.Add(this.drawingBoard);
            this.panelTestSet.Location = new System.Drawing.Point(175, 38);
            this.panelTestSet.Name = "panelTestSet";
            this.panelTestSet.Size = new System.Drawing.Size(625, 562);
            this.panelTestSet.TabIndex = 6;
            this.panelTestSet.Visible = false;
            this.panelTestSet.VisibleChanged += new System.EventHandler(this.TestSetPanel_Visible);
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.fileNameBox);
            this.savePanel.Controls.Add(this.buttonCancel);
            this.savePanel.Controls.Add(this.buttonSave);
            this.savePanel.Location = new System.Drawing.Point(184, 183);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(270, 136);
            this.savePanel.TabIndex = 9;
            this.savePanel.Visible = false;
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(31, 17);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(207, 26);
            this.fileNameBox.TabIndex = 2;
            this.fileNameBox.Text = "testSet";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(144, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 43);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(16, 71);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 43);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tableClasses
            // 
            this.tableClasses.ColumnCount = 1;
            this.tableClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClasses.Location = new System.Drawing.Point(14, 268);
            this.tableClasses.Name = "tableClasses";
            this.tableClasses.RowCount = 1;
            this.tableClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableClasses.Size = new System.Drawing.Size(599, 106);
            this.tableClasses.TabIndex = 8;
            // 
            // buttonSetSample
            // 
            this.buttonSetSample.Enabled = false;
            this.buttonSetSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetSample.Location = new System.Drawing.Point(214, 394);
            this.buttonSetSample.Name = "buttonSetSample";
            this.buttonSetSample.Size = new System.Drawing.Size(207, 48);
            this.buttonSetSample.TabIndex = 7;
            this.buttonSetSample.Text = "Записать";
            this.buttonSetSample.UseVisualStyleBackColor = true;
            this.buttonSetSample.Click += new System.EventHandler(this.ButtonSetSample_Click);
            // 
            // SaveTestSet
            // 
            this.SaveTestSet.Enabled = false;
            this.SaveTestSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTestSet.Location = new System.Drawing.Point(214, 460);
            this.SaveTestSet.Name = "SaveTestSet";
            this.SaveTestSet.Size = new System.Drawing.Size(207, 48);
            this.SaveTestSet.TabIndex = 6;
            this.SaveTestSet.Text = "Сохранить датасет";
            this.SaveTestSet.UseVisualStyleBackColor = true;
            this.SaveTestSet.Click += new System.EventHandler(this.SaveTestSet_Click);
            // 
            // drawingBoard
            // 
            this.drawingBoard.BackColor = System.Drawing.Color.White;
            this.drawingBoard.Image = ((System.Drawing.Image)(resources.GetObject("drawingBoard.Image")));
            this.drawingBoard.Location = new System.Drawing.Point(125, 0);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(400, 250);
            this.drawingBoard.TabIndex = 5;
            this.drawingBoard.TabStop = false;
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseUp);
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.loadTestSet);
            this.panelParam.Controls.Add(this.labelLoadTestSet);
            this.panelParam.Controls.Add(this.labelNumSymbolSamples);
            this.panelParam.Controls.Add(this.labelNumSamples);
            this.panelParam.Controls.Add(this.labelNumSymbols);
            this.panelParam.Controls.Add(this.numOfSymbolSamples);
            this.panelParam.Controls.Add(this.numOfSamples);
            this.panelParam.Controls.Add(this.numOfSymbols);
            this.panelParam.Controls.Add(this.buttonLoadTestSet);
            this.panelParam.Controls.Add(this.labelOr);
            this.panelParam.Controls.Add(this.separator);
            this.panelParam.Controls.Add(this.SetParameters);
            this.panelParam.Location = new System.Drawing.Point(175, 38);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(625, 562);
            this.panelParam.TabIndex = 6;
            this.panelParam.VisibleChanged += new System.EventHandler(this.ParamsPanel_Visible);
            // 
            // loadTestSet
            // 
            this.loadTestSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadTestSet.FormattingEnabled = true;
            this.loadTestSet.Location = new System.Drawing.Point(372, 118);
            this.loadTestSet.Name = "loadTestSet";
            this.loadTestSet.Size = new System.Drawing.Size(153, 28);
            this.loadTestSet.TabIndex = 11;
            // 
            // labelLoadTestSet
            // 
            this.labelLoadTestSet.AutoSize = true;
            this.labelLoadTestSet.Location = new System.Drawing.Point(368, 90);
            this.labelLoadTestSet.Name = "labelLoadTestSet";
            this.labelLoadTestSet.Size = new System.Drawing.Size(157, 20);
            this.labelLoadTestSet.TabIndex = 10;
            this.labelLoadTestSet.Text = "Выберите датасет:";
            // 
            // labelNumSymbolSamples
            // 
            this.labelNumSymbolSamples.AutoSize = true;
            this.labelNumSymbolSamples.Location = new System.Drawing.Point(44, 276);
            this.labelNumSymbolSamples.Name = "labelNumSymbolSamples";
            this.labelNumSymbolSamples.Size = new System.Drawing.Size(244, 20);
            this.labelNumSymbolSamples.TabIndex = 9;
            this.labelNumSymbolSamples.Text = "Количество образцов символа";
            this.labelNumSymbolSamples.Visible = false;
            // 
            // labelNumSamples
            // 
            this.labelNumSamples.AutoSize = true;
            this.labelNumSamples.Location = new System.Drawing.Point(44, 183);
            this.labelNumSamples.Name = "labelNumSamples";
            this.labelNumSamples.Size = new System.Drawing.Size(179, 20);
            this.labelNumSamples.TabIndex = 8;
            this.labelNumSamples.Text = "Количество образцов ";
            // 
            // labelNumSymbols
            // 
            this.labelNumSymbols.AutoSize = true;
            this.labelNumSymbols.Location = new System.Drawing.Point(44, 90);
            this.labelNumSymbols.Name = "labelNumSymbols";
            this.labelNumSymbols.Size = new System.Drawing.Size(178, 20);
            this.labelNumSymbols.TabIndex = 7;
            this.labelNumSymbols.Text = "Количество символов";
            // 
            // numOfSymbolSamples
            // 
            this.numOfSymbolSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfSymbolSamples.FormattingEnabled = true;
            this.numOfSymbolSamples.Location = new System.Drawing.Point(48, 304);
            this.numOfSymbolSamples.Name = "numOfSymbolSamples";
            this.numOfSymbolSamples.Size = new System.Drawing.Size(151, 28);
            this.numOfSymbolSamples.TabIndex = 6;
            this.numOfSymbolSamples.Visible = false;
            this.numOfSymbolSamples.SelectedValueChanged += new System.EventHandler(this.OnValueChanged_SymbolSamples);
            // 
            // numOfSamples
            // 
            this.numOfSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfSamples.FormattingEnabled = true;
            this.numOfSamples.Location = new System.Drawing.Point(48, 211);
            this.numOfSamples.Name = "numOfSamples";
            this.numOfSamples.Size = new System.Drawing.Size(151, 28);
            this.numOfSamples.TabIndex = 5;
            this.numOfSamples.SelectedValueChanged += new System.EventHandler(this.OnValueChanged_Samples);
            // 
            // numOfSymbols
            // 
            this.numOfSymbols.BackColor = System.Drawing.SystemColors.Window;
            this.numOfSymbols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfSymbols.FormattingEnabled = true;
            this.numOfSymbols.Location = new System.Drawing.Point(48, 118);
            this.numOfSymbols.Name = "numOfSymbols";
            this.numOfSymbols.Size = new System.Drawing.Size(151, 28);
            this.numOfSymbols.TabIndex = 4;
            this.numOfSymbols.SelectedValueChanged += new System.EventHandler(this.OnValueChanged_Symbol);
            // 
            // buttonLoadTestSet
            // 
            this.buttonLoadTestSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTestSet.Location = new System.Drawing.Point(368, 460);
            this.buttonLoadTestSet.Name = "buttonLoadTestSet";
            this.buttonLoadTestSet.Size = new System.Drawing.Size(207, 48);
            this.buttonLoadTestSet.TabIndex = 3;
            this.buttonLoadTestSet.Text = "Загрузить датасет";
            this.buttonLoadTestSet.UseVisualStyleBackColor = true;
            this.buttonLoadTestSet.Click += new System.EventHandler(this.ButtonLoadTestSet_Click);
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.BackColor = System.Drawing.Color.Transparent;
            this.labelOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOr.Location = new System.Drawing.Point(293, 230);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(43, 20);
            this.labelOr.TabIndex = 2;
            this.labelOr.Text = "ИЛИ";
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.LightSkyBlue;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.separator.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.separator.Location = new System.Drawing.Point(307, 8);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(5, 500);
            this.separator.TabIndex = 1;
            // 
            // SetParameters
            // 
            this.SetParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetParameters.Location = new System.Drawing.Point(48, 460);
            this.SetParameters.Name = "SetParameters";
            this.SetParameters.Size = new System.Drawing.Size(207, 48);
            this.SetParameters.TabIndex = 0;
            this.SetParameters.Text = "Задать параметры";
            this.SetParameters.UseVisualStyleBackColor = true;
            this.SetParameters.Click += new System.EventHandler(this.SetParameters_Click);
            // 
            // panelTrain
            // 
            this.panelTrain.Controls.Add(this.labelTotalError);
            this.panelTrain.Controls.Add(this.labelTotalErrorStatic);
            this.panelTrain.Controls.Add(this.buttonRemoveLayer);
            this.panelTrain.Controls.Add(this.layoutArchitexture);
            this.panelTrain.Controls.Add(this.textBoxDesiredError);
            this.panelTrain.Controls.Add(this.textBoxEta);
            this.panelTrain.Controls.Add(this.comboBoxType);
            this.panelTrain.Controls.Add(this.labelDesiredError);
            this.panelTrain.Controls.Add(this.labelEta);
            this.panelTrain.Controls.Add(this.labelType);
            this.panelTrain.Controls.Add(this.buttonAddLayer);
            this.panelTrain.Controls.Add(this.labelArchitecture);
            this.panelTrain.Controls.Add(this.errorChart);
            this.panelTrain.Controls.Add(this.Train);
            this.panelTrain.Controls.Add(this.GoToTest);
            this.panelTrain.Location = new System.Drawing.Point(175, 38);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(625, 562);
            this.panelTrain.TabIndex = 0;
            this.panelTrain.Visible = false;
            this.panelTrain.VisibleChanged += new System.EventHandler(this.TrainPanel_Visible);
            // 
            // labelTotalError
            // 
            this.labelTotalError.AutoSize = true;
            this.labelTotalError.Location = new System.Drawing.Point(319, 200);
            this.labelTotalError.Name = "labelTotalError";
            this.labelTotalError.Size = new System.Drawing.Size(0, 20);
            this.labelTotalError.TabIndex = 16;
            // 
            // labelTotalErrorStatic
            // 
            this.labelTotalErrorStatic.AutoSize = true;
            this.labelTotalErrorStatic.Location = new System.Drawing.Point(220, 200);
            this.labelTotalErrorStatic.Name = "labelTotalErrorStatic";
            this.labelTotalErrorStatic.Size = new System.Drawing.Size(73, 20);
            this.labelTotalErrorStatic.TabIndex = 15;
            this.labelTotalErrorStatic.Text = "Ошибка:";
            // 
            // buttonRemoveLayer
            // 
            this.buttonRemoveLayer.Enabled = false;
            this.buttonRemoveLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveLayer.Location = new System.Drawing.Point(157, 276);
            this.buttonRemoveLayer.Name = "buttonRemoveLayer";
            this.buttonRemoveLayer.Size = new System.Drawing.Size(155, 29);
            this.buttonRemoveLayer.TabIndex = 14;
            this.buttonRemoveLayer.Text = "Удалить слой";
            this.buttonRemoveLayer.UseVisualStyleBackColor = true;
            this.buttonRemoveLayer.Click += new System.EventHandler(this.ButtonRemoveLayer_Click);
            // 
            // layoutArchitexture
            // 
            this.layoutArchitexture.ColumnCount = 2;
            this.layoutArchitexture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutArchitexture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutArchitexture.Location = new System.Drawing.Point(157, 236);
            this.layoutArchitexture.Name = "layoutArchitexture";
            this.layoutArchitexture.RowCount = 2;
            this.layoutArchitexture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutArchitexture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutArchitexture.Size = new System.Drawing.Size(456, 29);
            this.layoutArchitexture.TabIndex = 13;
            // 
            // textBoxDesiredError
            // 
            this.textBoxDesiredError.Location = new System.Drawing.Point(215, 399);
            this.textBoxDesiredError.Name = "textBoxDesiredError";
            this.textBoxDesiredError.Size = new System.Drawing.Size(208, 26);
            this.textBoxDesiredError.TabIndex = 12;
            this.textBoxDesiredError.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DesiredError_Changed);
            this.textBoxDesiredError.Leave += new System.EventHandler(this.DesiredError_Left);
            // 
            // textBoxEta
            // 
            this.textBoxEta.Location = new System.Drawing.Point(215, 363);
            this.textBoxEta.Name = "textBoxEta";
            this.textBoxEta.Size = new System.Drawing.Size(208, 26);
            this.textBoxEta.TabIndex = 11;
            this.textBoxEta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Eta_Changed);
            this.textBoxEta.Leave += new System.EventHandler(this.Eta_Left);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(215, 325);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(208, 28);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.SelectedValueChanged += new System.EventHandler(this.OnValueChanged_Type);
            // 
            // labelDesiredError
            // 
            this.labelDesiredError.AutoSize = true;
            this.labelDesiredError.Location = new System.Drawing.Point(10, 405);
            this.labelDesiredError.Name = "labelDesiredError";
            this.labelDesiredError.Size = new System.Drawing.Size(141, 20);
            this.labelDesiredError.TabIndex = 9;
            this.labelDesiredError.Text = "Целевая ошибка:";
            // 
            // labelEta
            // 
            this.labelEta.AutoSize = true;
            this.labelEta.Location = new System.Drawing.Point(10, 369);
            this.labelEta.Name = "labelEta";
            this.labelEta.Size = new System.Drawing.Size(159, 20);
            this.labelEta.TabIndex = 8;
            this.labelEta.Text = "Скорость обучения:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(10, 333);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(64, 20);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Метод:";
            // 
            // buttonAddLayer
            // 
            this.buttonAddLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLayer.Location = new System.Drawing.Point(328, 276);
            this.buttonAddLayer.Name = "buttonAddLayer";
            this.buttonAddLayer.Size = new System.Drawing.Size(155, 29);
            this.buttonAddLayer.TabIndex = 6;
            this.buttonAddLayer.Text = "Добавить слой";
            this.buttonAddLayer.UseVisualStyleBackColor = true;
            this.buttonAddLayer.Click += new System.EventHandler(this.ButtonAddLayer_Click);
            // 
            // labelArchitecture
            // 
            this.labelArchitecture.AutoSize = true;
            this.labelArchitecture.Location = new System.Drawing.Point(10, 244);
            this.labelArchitecture.Name = "labelArchitecture";
            this.labelArchitecture.Size = new System.Drawing.Size(136, 20);
            this.labelArchitecture.TabIndex = 4;
            this.labelArchitecture.Text = "Архитектура НС:";
            // 
            // errorChart
            // 
            chartArea4.Name = "ChartArea1";
            this.errorChart.ChartAreas.Add(chartArea4);
            this.errorChart.Location = new System.Drawing.Point(114, 0);
            this.errorChart.Name = "errorChart";
            this.errorChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Name = "SymbolError";
            this.errorChart.Series.Add(series4);
            this.errorChart.Size = new System.Drawing.Size(411, 194);
            this.errorChart.TabIndex = 3;
            this.errorChart.Text = "Ошибка за период";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.Name = "Title1";
            title4.Text = "Класс датасета:";
            this.errorChart.Titles.Add(title4);
            // 
            // Train
            // 
            this.Train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Train.Location = new System.Drawing.Point(214, 460);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(207, 48);
            this.Train.TabIndex = 1;
            this.Train.Text = "Тренировать";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // GoToTest
            // 
            this.GoToTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToTest.Location = new System.Drawing.Point(214, 460);
            this.GoToTest.Name = "GoToTest";
            this.GoToTest.Size = new System.Drawing.Size(207, 48);
            this.GoToTest.TabIndex = 2;
            this.GoToTest.Text = "Тестировать НС";
            this.GoToTest.UseVisualStyleBackColor = true;
            this.GoToTest.Visible = false;
            this.GoToTest.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // panelTest
            // 
            this.panelTest.Controls.Add(this.resultClasses);
            this.panelTest.Controls.Add(this.labelClass);
            this.panelTest.Controls.Add(this.labelClassStatic);
            this.panelTest.Controls.Add(this.drawingBoardTest);
            this.panelTest.Controls.Add(this.Test);
            this.panelTest.Location = new System.Drawing.Point(175, 38);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(625, 562);
            this.panelTest.TabIndex = 0;
            this.panelTest.Visible = false;
            this.panelTest.VisibleChanged += new System.EventHandler(this.TestPanel_Visible);
            // 
            // resultClasses
            // 
            this.resultClasses.ColumnCount = 2;
            this.resultClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultClasses.Location = new System.Drawing.Point(125, 266);
            this.resultClasses.Name = "resultClasses";
            this.resultClasses.RowCount = 2;
            this.resultClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultClasses.Size = new System.Drawing.Size(400, 67);
            this.resultClasses.TabIndex = 6;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(270, 377);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(0, 20);
            this.labelClass.TabIndex = 5;
            // 
            // labelClassStatic
            // 
            this.labelClassStatic.AutoSize = true;
            this.labelClassStatic.Location = new System.Drawing.Point(130, 377);
            this.labelClassStatic.Name = "labelClassStatic";
            this.labelClassStatic.Size = new System.Drawing.Size(135, 20);
            this.labelClassStatic.TabIndex = 4;
            this.labelClassStatic.Text = "Класс датасета:";
            // 
            // drawingBoardTest
            // 
            this.drawingBoardTest.Image = global::Backpropagation.Properties.Resources.Board;
            this.drawingBoardTest.Location = new System.Drawing.Point(125, 0);
            this.drawingBoardTest.Name = "drawingBoardTest";
            this.drawingBoardTest.Size = new System.Drawing.Size(400, 250);
            this.drawingBoardTest.TabIndex = 3;
            this.drawingBoardTest.TabStop = false;
            this.drawingBoardTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseDown);
            this.drawingBoardTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseMove);
            this.drawingBoardTest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseUp);
            // 
            // Test
            // 
            this.Test.Enabled = false;
            this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test.Location = new System.Drawing.Point(214, 460);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(207, 48);
            this.Test.TabIndex = 0;
            this.Test.Text = "Тестировать символ";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelParam);
            this.Controls.Add(this.panelTestSet);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.panelSlider);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.progressionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Main_Load);
            this.progressionPanel.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.panelTestSet.ResumeLayout(false);
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).EndInit();
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.panelTrain.ResumeLayout(false);
            this.panelTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).EndInit();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoardTest)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private FlowLayoutPanel progressionPanel;
		private Button buttonExit;
		private Panel titleBar;
		private Panel panelIcon;
		private Button buttonParams;
		private Button buttonTestSet;
		private Button buttonTrain;
		private Button buttonTest;
		private Panel panelSlider;
		private PictureBox drawingBoard;
		private Panel panelTestSet;
		private Panel panelParam;
		private Panel panelTrain;
		private Button Train;
		private Panel panelTest;
		private Button SetParameters;
		private Button SaveTestSet;
		private Button GoToTest;
		private Button Test;
		private Label labelOr;
		private Label separator;
		private Button buttonLoadTestSet;
		private ComboBox numOfSymbolSamples;
		private ComboBox numOfSamples;
		private ComboBox numOfSymbols;
		private ComboBox loadTestSet;
		private Label labelLoadTestSet;
		private Label labelNumSymbolSamples;
		private Label labelNumSamples;
		private Label labelNumSymbols;
		private Button buttonSetSample;
		private TableLayoutPanel tableClasses;
		private Panel savePanel;
		private TextBox fileNameBox;
		private Button buttonCancel;
		private Button buttonSave;
		private PictureBox drawingBoardTest;
		private Label labelClass;
		private Label labelClassStatic;
		private System.Windows.Forms.DataVisualization.Charting.Chart errorChart;
		private TextBox textBoxDesiredError;
		private TextBox textBoxEta;
		private ComboBox comboBoxType;
		private Label labelDesiredError;
		private Label labelEta;
		private Label labelType;
		private Button buttonAddLayer;
		private Label labelArchitecture;
		private TableLayoutPanel layoutArchitexture;
		private Button buttonRemoveLayer;
		private Label labelTotalError;
		private Label labelTotalErrorStatic;
		private TableLayoutPanel resultClasses;
	}
}

