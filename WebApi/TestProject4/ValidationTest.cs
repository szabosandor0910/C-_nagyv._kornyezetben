using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject4
{
    [TestClass]
    public class ValidationTest
    {

        // Ha a dependencynél addolom a projecteket felkiáltójel lesz rajta és nem tudok hivatkozni rájuk. Kommenteben hogy kb milyennek kéne lennie.


        [TestMethod]
        public void TestMethod1()
        {
        }

        /*
        [TestMethod]

        public void ValidateBookTestTrue()
        {
        CimTextBox.Text = "Asd"
        KolcsonozteTextBox.Text = "asd"
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = "2020.10.30";

        Assert.AreEqual(UjKonyv.ValidateBook(), true);
        }

        [TestMethod]

        public void ValidateBookTestFalse1()
        {
        CimTextBox.Text = null
        KolcsonozteTextBox.Text = "asd"
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = "2020.10.30";

        Assert.AreEqual(UjKonyv.ValidateBook(), false);
        }

        [TestMethod]

        public void ValidateBookTestFalse2()
        {
        CimTextBox.Text = "dfsdf"
        KolcsonozteTextBox.Text = null
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = "2020.10.30";

        Assert.AreEqual(UjKonyv.ValidateBook(), false);
        }

        [TestMethod]

        public void ValidateBookTestFalse3()
        {
        CimTextBox.Text = "dfsdf"
        KolcsonozteTextBox.Text = "sdfsdf"
        KezdoDatePicker.SelectedDate.Value = null;
        VegeDatePicker.SelectedDate.Value = "2020.10.30";

        Assert.AreEqual(UjKonyv.ValidateBook(), false);
        }

        [TestMethod]

        public void ValidateBookTestFalse4()
        {
        CimTextBox.Text = "dfsdf"
        KolcsonozteTextBox.Text = "sdfsdf"
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = null;

        Assert.AreEqual(UjKonyv.ValidateBook(), false);
        }


        [TestMethod]

        public void ValidateDateTestTrue()
        {
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = "2020.11.30";

        Assert.AreEqual(UjKonyv.ValidateDate(), true);
        }

        [TestMethod]

        public void ValidateDateTestFalse()
        {
        KezdoDatePicker.SelectedDate.Value = "2020.10.30";
        VegeDatePicker.SelectedDate.Value = "2020.09.30";

        Assert.AreEqual(UjKonyv.ValidateDate(), false);
        }
         
        

          */
    }
}
