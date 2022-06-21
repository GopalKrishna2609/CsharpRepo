using OrderAssignmentEF;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
        TOP:
            string getValue;
            CRUDManager curdManager = new CRUDManager();
            Console.WriteLine("1. Item Master\n2. Customer Master\n3. Book Item\n4. Close Application");
            switch (Console.ReadLine())
            {
                case "1":
                    getValue = Print();
                    if (getValue == "1") curdManager.InsertItem();
                    if (getValue == "2") curdManager.UpdateItem();
                    if (getValue == "3") curdManager.DeleteItem();
                    if (getValue == "4") curdManager.ShowOneItem();
                    if (getValue == "5") curdManager.ShowAllItems();
                    break;
                case "2":
                    getValue = Print();
                    if (getValue == "1") curdManager.InsertCustomer();
                    if (getValue == "2") curdManager.UpdateCustomer();
                    if (getValue == "3") curdManager.DeleteCustomer();
                    if (getValue == "4") curdManager.ShowOneCustomer();
                    if (getValue == "5") curdManager.ShowAllCustomers();
                    break;
                case "3":
                    curdManager.Verify();
                    break;
                case "4": return;
                default:
                    Console.WriteLine("Please Enter Correct Option - ");
                    goto TOP;
            }
            goto TOP;
        }
        static string Print()
        {
        TOP:
            Console.WriteLine("1. InsertOneRecord\n2. UpdateOneRecord\n3. DeleteOneRecord\n4. ShowOneRecord\n5. ShowAllRecords\n6. Go Back");
            string input = Console.ReadLine();
            if (input == "1") return input;
            if (input == "2") return input;
            if (input == "3") return input;
            if (input == "4") return input;
            if (input == "5") return input;
            if (input == "6") return null;
            else
            {
                Console.WriteLine("Please Enter Correct Option -");
                goto TOP;
            }
        }
    }
}