namespace laba1kmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            matrix();
        }

        private void InitializeGrid()
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void matrix()
        {
            int[,] predefinedMatrix = new int[1, 5]
 {
    
      {1, 2, 3, 4, 5}
 };

            // ���������, ��� ������� ������� ��������� � ��������� DataGridView
            if (predefinedMatrix.GetLength(0) == dataGridView1.Rows.Count &&
                predefinedMatrix.GetLength(1) == dataGridView1.Columns.Count)
            {
                // ��������� DataGridView ���������� �� ����������������� �������
                for (int i = 0; i < predefinedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < predefinedMatrix.GetLength(1); j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = predefinedMatrix[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("������� ����������������� ������� �� ��������� � ��������� DataGridView.");
            }

        }
    }
}
