using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PavlovaVV.Sprint7.Project.V2.Lib;
namespace Tyuiu.PavlovaVV.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {

            InitializeComponent();
            openFileDialog_PVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            InitializeFilterComboBox();

        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void InitializeFilterComboBox()
        {
            comboBoxNames_PVV.Items.Clear();
            comboBoxNames_PVV.Items.Add("Все колонки");
            comboBoxNames_PVV.SelectedIndex = 0;
        }

       
        private void buttonOpen_PVV_Click(object sender, EventArgs e)
        {
            openFileDialog_PVV.ShowDialog();
            openFilePath = openFileDialog_PVV.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_PVV.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_PVV.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_PVV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            // ОБНОВЛЯЕМ ComboBox после загрузки данных
            UpdateFilterComboBox();

            if (dataGridViewData_PVV.Rows.Count != 0)
            {
                buttonDel_PVV.Enabled = true;
            }
        }

        private void UpdateFilterComboBox()
        {
            // Сохраняем текущий выбор
            int savedSelection = comboBoxNames_PVV.SelectedIndex;

            comboBoxNames_PVV.Items.Clear();
            comboBoxNames_PVV.Items.Add("Все колонки");

            
            if (dataGridViewData_PVV.Columns.Count > 0)
            {
                
                for (int i = 0; i < dataGridViewData_PVV.Columns.Count; i++)
                {
                    string header = dataGridViewData_PVV.Columns[i].HeaderText;
                    if (string.IsNullOrEmpty(header))
                    {
                        header = $"Колонка {i + 1}";
                    }
                    comboBoxNames_PVV.Items.Add(header);
                }
            }

            // Восстанавливаем выбор колонок
            if (savedSelection >= 0 && savedSelection < comboBoxNames_PVV.Items.Count)
            {
                comboBoxNames_PVV.SelectedIndex = savedSelection;
            }
            else
            {
                comboBoxNames_PVV.SelectedIndex = 0;
            }
        }
        private void buttonDownload_PVV_Click_1(object sender, EventArgs e)
        {
            saveFileDialog_PVV.FileName = "DataBase.csv";
            saveFileDialog_PVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_PVV.ShowDialog();


            string path = saveFileDialog_PVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewData_PVV.RowCount;
            int columns = dataGridViewData_PVV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewData_PVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewData_PVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonAdd_PVV_Click_1(object sender, EventArgs e)
        {

            try
            {
                int newRowIndex = dataGridViewData_PVV.Rows.Add();
                string numberColumnName = dataGridViewData_PVV.Columns.Count > 0 ? dataGridViewData_PVV.Columns[0].Name : null;

                if (!string.IsNullOrEmpty(numberColumnName))
                {
                    dataGridViewData_PVV.Rows[newRowIndex].Cells[numberColumnName].Value = newRowIndex + 1;
                }

                if (dataGridViewData_PVV.Rows.Count > 0)
                {
                    buttonDel_PVV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления новой строки {ex.Message}");
            }
        }

        private void buttonDel_PVV_Click_1(object sender, EventArgs e)
        {
            dataGridViewData_PVV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewData_PVV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Строка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные строки?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {

                List<int> rowsToDelete = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridViewData_PVV.SelectedRows)
                    rowsToDelete.Add(selectedRow.Index);

                for (int i = rowsToDelete.Count - 1; i >= 0; i--)
                {
                    dataGridViewData_PVV.Rows.RemoveAt(rowsToDelete[i]);
                }

                dataGridViewData_PVV.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataGridViewData_PVV.Rows.Count == 0)
            {
                buttonDel_PVV.Enabled = false;
            }
        }


        private void buttonFilter_PVV_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewData_PVV.Rows)
            {
                if ((r.Cells[comboBoxNames_PVV.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_PVV.Text.ToUpper()))
                {
                    dataGridViewData_PVV.Rows[r.Index].Visible = true;
                    dataGridViewData_PVV.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewData_PVV.CurrentCell = null;
                    dataGridViewData_PVV.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxNames_PVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNames_PVV.SelectedIndex != 0)
            {
                textBoxFilter_PVV.Enabled = true;
                textBoxFilter_PVV.Enabled = true;
            }
            else
            {
                textBoxFilter_PVV.Enabled = false;
                textBoxFilter_PVV.Enabled = false;
            }
        }
        private void buttonStats_PVV_Click_1(object sender, EventArgs e)
        {
            chartMoney_PVV.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Сумма выручки в месяц");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewData_PVV.Rows)
            {
                if (!row.IsNewRow && row.Cells[3] != null && row.Cells[3].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[3].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartMoney_PVV.Series.Add(series);
        }

        private void dataGridViewData_PVV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewData_PVV.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewData_PVV.Rows[index].HeaderCell.Value = indexStr;
        }

        private void textBoxSearch_PVV_TextChanged(object sender, EventArgs e)
        {

            string currentText = textBoxSearch_PVV.Text;
            foreach (DataGridViewRow row in dataGridViewData_PVV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(currentText) && cell.Value.ToString().ToUpper().Contains(currentText.ToUpper()))
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstruction FormInstruction = new FormInstruction();
            FormInstruction.ShowDialog();
        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.ShowDialog();
        }

        private void textBoxFilter_PVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_PVV.Rows.Count == 0 ||
       (dataGridViewData_PVV.Rows.Count == 1 && dataGridViewData_PVV.Rows[0].IsNewRow))
            {
                MessageBox.Show("Нет данных для расчета статистики",
                               "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // данные о капитале
            List<double> capitals = new List<double>();
            List<string> addresses = new List<string>();

            foreach (DataGridViewRow row in dataGridViewData_PVV.Rows)
            {
                if (!row.IsNewRow && row.Cells[3] != null && row.Cells[3].Value != null)
                {
                    if (double.TryParse(row.Cells[3].Value.ToString(), out double capital))
                    {
                        capitals.Add(capital);
                        addresses.Add(row.Cells[2].Value?.ToString() ?? "Неизвестно");
                    }
                }
            }

            if (capitals.Count == 0)
            {
                MessageBox.Show("Нет данных о капитале для расчета",
                               "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Расчет статистики
            double sum = capitals.Sum();
            double average = capitals.Average();
            double min = capitals.Min();
            double max = capitals.Max();
            double median = CalculateMedian(capitals);
            double stdDev = CalculateStandardDeviation(capitals);

            // Находим точку с максимальным и минимальным капиталом
            int maxIndex = capitals.IndexOf(max);
            int minIndex = capitals.IndexOf(min);
            string maxAddress = addresses[maxIndex];
            string minAddress = addresses[minIndex];

            // Формируем отчет
            string report = $"СТАТИСТИКА ПО КАПИТАЛУ\n" +
                           $"=========================\n" +
                           $"Всего точек: {capitals.Count}\n" +
                           $"Суммарный капитал: {sum:N0} руб\n" +
                           $"Средний капитал: {average:N0} руб\n" +
                           $"Медианный капитал: {median:N0} руб\n" +
                           $"Минимальный капитал: {min:N0} руб\n" +
                           $"  (адрес: {minAddress})\n" +
                           $"Максимальный капитал: {max:N0} руб\n" +
                           $"  (адрес: {maxAddress})\n" +
                           $"Стандартное отклонение: {stdDev:N0} руб\n" +
                           $"Диапазон: {max - min:N0} руб\n" +
                           $"=========================\n" +
                           $"Топ-5 точек по капиталу:\n";

            // Топ-5 точек
            var top5 = capitals.Zip(addresses, (cap, addr) => new { Capital = cap, Address = addr })
                               .OrderByDescending(x => x.Capital)
                               .Take(5);

            int rank = 1;
            foreach (var item in top5)
            {
                report += $"{rank}. {item.Address}: {item.Capital:N0} руб\n";
                rank++;
            }

            // Показываем отчет
            MessageBox.Show(report, "Статистика по капиталу",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Расчет медианы
        private double CalculateMedian(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return 0;

            var sorted = numbers.OrderBy(n => n).ToList();
            int count = sorted.Count;

            if (count % 2 == 0)
            {
                return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;
            }
            else
            {
                return sorted[count / 2];
            }
        }

        // Расчет стандартного отклонения
        private double CalculateStandardDeviation(List<double> numbers)
        {
            if (numbers == null || numbers.Count < 2)
                return 0;

            double avg = numbers.Average();
            double sumOfSquares = numbers.Sum(num => Math.Pow(num - avg, 2));
            return Math.Sqrt(sumOfSquares / (numbers.Count - 1));
        }
    }
}
