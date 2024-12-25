public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            var data = context.MyTable.FirstOrDefault();
        }

        // Error: Object disposed
        var moreData = context.MyTable.FirstOrDefault(); 
    }
}