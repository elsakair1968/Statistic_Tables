using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Statistic_Table
{
    public partial class Prosecution_Partial : Form
    {
        private PartialProsecutionRepository _repo;
        //private DataTable _dataTable;
        private int _currentId = 0; // لتحديد السجل الحالي 
        private DatabaseHelper _db;
        //private bool _isEditMode = false;     // ✅ متغير جديد: وضع التعديل
        internal PartialProsecutionRepository Repo { get => _repo; set => _repo = value; }

        public Prosecution_Partial()
        {
            InitializeComponent();
            Repo = new PartialProsecutionRepository();
            _db = new DatabaseHelper();

        }
        private void PartialProsecutionForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        // === تحميل البيانات إلى DataGridView ===
        private void LoadData()
        {
            // أولاً: اختبار الاتصال
            string testQuery = "SELECT 1";
            DataTable testDt = _db.ExecuteQuery(testQuery);
            MessageBox.Show("✅ الاتصال بقاعدة البيانات ناجح!", "اختبار الاتصال");
            try
            {
                string query = "SELECT ID, Code, Number, Name, None AS IsActive FROM Prosecution_Partial_LBT";
                DataTable dt = _db.ExecuteQuery(query);
                dgvProsecutions.DataSource = dt;
                // تنسيق العناوين بالعربية  
                if (dgvProsecutions.Columns["ID"] != null)
                    dgvProsecutions.Columns["ID"].HeaderText = "المعرف";
                if (dgvProsecutions.Columns["Code"] != null)
                    dgvProsecutions.Columns["Code"].HeaderText = "الكود";
                if (dgvProsecutions.Columns["Number"] != null)
                    dgvProsecutions.Columns["Number"].HeaderText = "رقم النيابة";
                if (dgvProsecutions.Columns["Name"] != null)
                    dgvProsecutions.Columns["Name"].HeaderText = "اسم النيابة";
                if (dgvProsecutions.Columns["IsActive"] != null)
                    dgvProsecutions.Columns["IsActive"].HeaderText = "مفعل";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === تفريغ الحقول ===
        private void ClearFields()
        {
            TxtID.Text = "";
            TxtCode.Text = "";
            TxtNumber.Text = "";
            TxtName.Text = "";
            TxtNotes.Text = "";
            ChkActive.Checked = false;
            _currentId = 0;
        }

        // === تعبئة الحقول من الصف المحدد في DataGridView ===
        private void dgvProsecutions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProsecutions.CurrentRow != null && dgvProsecutions.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvProsecutions.CurrentRow;
                TxtID.Text = row.Cells["ID"].Value?.ToString();
                TxtCode.Text = row.Cells["Code"].Value?.ToString();
                TxtNumber.Text = row.Cells["Number"].Value?.ToString();
                TxtName.Text = row.Cells["Name"].Value?.ToString();
                ChkActive.Checked = row.Cells["None"].Value != null && Convert.ToBoolean(row.Cells["None"].Value);
                _currentId = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        // === زر حفظ (القرص المرن) ===
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new PartialProsecution
                {
                    Code = string.IsNullOrEmpty(TxtCode.Text) ? 0 : Convert.ToInt32(TxtCode.Text),
                    Number = string.IsNullOrEmpty(TxtNumber.Text) ? 0 : Convert.ToInt32(TxtNumber.Text),
                    Name = TxtName.Text,
                    IsActive = ChkActive.Checked,
                    Note = TxtName.Text != null ? Encoding.UTF8.GetBytes(TxtName.Text) : null
                };

                if (_currentId == 0) // إضافة جديدة
                {
                    int newId = Repo.Add(item);
                    MessageBox.Show($"تمت الإضافة بنجاح، المعرف: {newId}", "نجاح",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // تحديث
                {
                    item.ID = _currentId;
                    Repo.Update(item);
                    MessageBox.Show("تم التحديث بنجاح", "نجاح",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ: {ex.Message}", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === زر تعديل (القلم) ===
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_currentId > 0)
            //{
            //    // تفعيل الحقول للتعديل
            //    TxtCode.Focus();
            //}
            {
                // تفعيل وضع التعديل
                //_isEditMode = true;

                // تغيير مظهر الأزرار
                BtnSave.Text = "تحديث";    // تغيير نص زر الحفظ
                BtnEdit.Enabled = false;    // تعطيل زر التعديل
                BtnDelete.Enabled = false;  // تعطيل زر الحذف

                // تفعيل الحقول
                TxtCode.Enabled = true;
                TxtNumber.Enabled = true;
                TxtName.Enabled = true;
                ChkActive.Enabled = true;

                // التركيز على حقل الكود
                TxtCode.Focus();
            }
            else
            {
                MessageBox.Show("الرجاء اختيار سجل للتعديل", "تنبيه",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // === زر حذف (المقص) ===
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_currentId > 0)
            {
                var result = MessageBox.Show("هل أنت متأكد من حذف هذا السجل؟", "تأكيد الحذف",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Repo.Delete(_currentId);
                    LoadData();
                    ClearFields();
                    MessageBox.Show("تم الحذف بنجاح", "نجاح",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار سجل للحذف", "تنبيه",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // === زر تحديث (السهمين الدائريين) ===
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        // === زر بحث ===
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //string keyword = Microsoft.VisualBasic.Interaction.InputBox("أدخل كلمة البحث:", "بحث", "");
            //if (!string.IsNullOrEmpty(keyword))
            //{
            //    _dataTable = _repo.Search(keyword);
            //    dataGridView1.DataSource = _dataTable;
            //}
        }

        // === زر طباعة (اختياري) ===
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // يمكن إضافة طباعة باستخدام PrintDialog أو ReportViewer
            MessageBox.Show("سيتم تفعيل طباعة التقرير قريباً", "طباعة",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Prosecution_Partial_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }
        private void TxtNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(TxtNumber.Text))
                {
                    SearchByNumber(TxtNumber.Text.Trim());
                }
                else
                {
                    LoadData();
                }
            }
        }



        private void SearchByNumber(string number)
        {
            try
            {
                // البحث حسب رقم النيابة
                string query = @"SELECT ID, Code, Number, Name, None AS IsActive 
                         FROM Prosecution_Partial_LBT 
                         WHERE Number LIKE @Number 
                         ORDER BY ID";

                SqlParameter[] param = {
            new SqlParameter("@Number", "%" + number + "%")  // بحث جزئي
        };

                DataTable dt = _db.ExecuteQuery(query, param);
                dgvProsecutions.DataSource = dt;

                // تنسيق العناوين
                FormatDataGridView();

                // إظهار عدد النتائج
                if (dt.Rows.Count > 0)
                {
                    // يمكنك إظهار العدد في شريط الحالة إذا أردت
                    // lblResultCount.Text = $"عدد النتائج: {dt.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في البحث: {ex.Message}", "خطأ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dgvProsecutions.Columns["ID"] != null)
                dgvProsecutions.Columns["ID"].HeaderText = "المعرف";
            if (dgvProsecutions.Columns["Code"] != null)
                dgvProsecutions.Columns["Code"].HeaderText = "الكود";
            if (dgvProsecutions.Columns["Number"] != null)
                dgvProsecutions.Columns["Number"].HeaderText = "رقم النيابة";
            if (dgvProsecutions.Columns["Name"] != null)
                dgvProsecutions.Columns["Name"].HeaderText = "اسم النيابة";
            if (dgvProsecutions.Columns["IsActive"] != null)
                dgvProsecutions.Columns["IsActive"].HeaderText = "مفعل";
        }

      
    }
    public static class InputDialog
    {
        public static string Show(string text, string caption, string defaultValue = "")
        {
            using (var form = new Form())
            {
                form.Text = caption;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.MinimizeBox = false; form.MaximizeBox = false;
                form.ClientSize = new Size(420, 120);

                var lbl = new Label { Left = 10, Top = 10, Text = text, AutoSize = true };
                var txt = new TextBox { Left = 10, Top = 30, Width = 400, Text = defaultValue };
                var ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Left = 240, Width = 80, Top = 60 };
                var cancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Left = 330, Width = 80, Top = 60 };

                form.Controls.AddRange(new Control[] { lbl, txt, ok, cancel });
                form.AcceptButton = ok;
                form.CancelButton = cancel;

                return form.ShowDialog() == DialogResult.OK ? txt.Text : "";
            }
        }
    }
}