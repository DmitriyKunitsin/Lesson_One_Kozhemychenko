namespace Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radioRow.Checked = false;
            radioCol.Checked = false;
            originDGV.Rows.Clear();
            resultDGV.Rows.Clear();
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            resultDGV.Rows.Clear();
            resultDGV.Columns.Clear();
            if (!chkNeg.Checked && !chkPos.Checked)
            {
                MessageBox.Show("Ошибка! Не выбрана группировка!");
            }
            else
            {
                if (radioCol.Checked)
                {
                    resultDGV.RowCount = 1;
                    resultDGV.ColumnCount = originDGV.ColumnCount;
                    for (int i = 0; i < originDGV.ColumnCount; i++)
                    {
                        double colAvg = new double();
                        int counter = 0;
                        for (int j = 0; j < originDGV.RowCount; j++)
                        {
                            double value = Convert.ToDouble(originDGV.Rows[j].Cells[i].Value);
                            if (((value >= 0) == chkPos.Checked) || (((value < 0) == chkNeg.Checked)))
                            {
                                colAvg += value;
                                counter++;
                            }
                        }
                        if (counter != 0) resultDGV[i, 0].Value = (colAvg / counter);
                        else resultDGV[i, 0].Value = 0;
                    }
                }
                else if (radioRow.Checked)
                {
                    resultDGV.RowCount = originDGV.RowCount;
                    resultDGV.ColumnCount = 1;
                    for (int i = 0; i < originDGV.RowCount; i++)
                    {
                        double rowAvg = new double();
                        int counter = 0;
                        for (int j = 0; j < originDGV.ColumnCount; j++)
                        {
                            double value = Convert.ToDouble(originDGV.Rows[i].Cells[j].Value);
                            if (((value >= 0) == chkPos.Checked) || (((value < 0) == chkNeg.Checked)))
                            {
                                rowAvg += value;
                                counter++;
                            }
                        }
                        if (counter != 0) resultDGV[0, i].Value = (rowAvg / counter);
                        else resultDGV[0, i].Value = 0;

                    }
                }
                else
                {
                    MessageBox.Show("Ошибка! Не выбрана область поиска среднего!");
                }
            }

        }

        private void matrixN_NUD_ValueChanged(object sender, EventArgs e)
        {
            originDGV.RowCount = Convert.ToInt32(matrixN_NUD.Value);
        }

        private void matrixM_NUD_ValueChanged(object sender, EventArgs e)
        {
            originDGV.ColumnCount = Convert.ToInt32(matrixM_NUD.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originDGV.RowCount = originDGV.ColumnCount = 2;
        }
    }
}
