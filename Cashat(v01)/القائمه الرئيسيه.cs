namespace Cashat_v01_
{
    public partial class القائمه_الرئيسيه : Form
    {
        public القائمه_الرئيسيه()
        {
            InitializeComponent();
        }

      //   void LinkMethod(string x,string y)
      // {
      //      string X = x;
      //      string Y = y;
      //      string z = "new";
      //      X  Y = z X();
      //      Y.Show();
      //     this.Close();
      // }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            النسخ_الاحتياطي Backup = new النسخ_الاحتياطي();
            Backup.Show();
            this.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            البيانات_الأساسيه basic_information = new البيانات_الأساسيه();
            basic_information.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            بيانات_الموردين Supplier_data = new بيانات_الموردين();
            Supplier_data.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            بيانات_العملاء customer_data = new بيانات_العملاء();
            customer_data.Show();
            this.Close();
        }

        private void القائمه_الرئيسيه_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            بيانات_المخازن store_data = new بيانات_المخازن();
            store_data.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            بيانات_الأصناف Item_data = new بيانات_الأصناف();
            Item_data.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            بيانات_الخزائن locker_data = new بيانات_الخزائن();
            locker_data.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            بيانات_البنوك bank_data = new بيانات_البنوك();
            bank_data.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            بيانات_جاري_الشركه Company_current_data = new بيانات_جاري_الشركه();
            Company_current_data.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            بيانات_العهد Covenant_data = new بيانات_العهد();
            Covenant_data.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            بيانات_المصروفات Expense_data = new بيانات_المصروفات();
            Expense_data.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            بيانات_المستخدمين user_data = new بيانات_المستخدمين();
            user_data.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            بيانات_الموظفين Employee_data = new بيانات_الموظفين();
            Employee_data.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            بيانات_المندوبين Delegates_data = new بيانات_المندوبين();
            Delegates_data.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            مخزون_أول_المده stock_first_term = new مخزون_أول_المده();
            stock_first_term.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            تحويلات_مخازن Transfers_stores = new تحويلات_مخازن();
            Transfers_stores.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            اذن_صرف Dismissal_notice = new اذن_صرف();
            Dismissal_notice.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            اذن_اضافة permission_add = new اذن_اضافة();
            permission_add.Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            اذن_تسوية permission_settlement = new اذن_تسوية();
            permission_settlement.Show();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
          
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            الأسعار prices = new الأسعار();
            prices.Show();
            this.Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            التقارير Reports = new التقارير();
            Reports.Show();
            this.Close();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            الاعدادات Settings = new الاعدادات();
            Settings.Show();
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            يومية_الموظفين daily_staff = new يومية_الموظفين();
            daily_staff.Show();
            this.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            المرتبات salaries = new المرتبات();
            salaries.Show();
            this.Close();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            المصروفات expenses = new المصروفات();
            expenses.Show();
            this.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            الخزينه treasury = new الخزينه();
            treasury.Show();
            this.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            فاتورة_مبيعات sales_bill = new فاتورة_مبيعات();
            sales_bill.Show();
            this.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            مرتجع_مبيعات sales_returns = new مرتجع_مبيعات();
            sales_returns.Show();
            this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            استلام_النقديه_شيكات Receiving_cash_checks = new استلام_النقديه_شيكات();
            Receiving_cash_checks.Show();
            this.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            فاتورة_شراء receipt = new فاتورة_شراء();
            receipt.Show();
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            مرتجع_شراء return_purchase = new مرتجع_شراء();
            return_purchase.Show();
            this.Close();
        }
    }
}
