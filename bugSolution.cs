public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            var data = context.MyTable.FirstOrDefault();
            //All database operations should be within the using block.
            var moreData = context.MyTable.Where(x=> x.Id > 10).FirstOrDefault();
        }
        
    }
}