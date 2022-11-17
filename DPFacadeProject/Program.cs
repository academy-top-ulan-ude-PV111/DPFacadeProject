namespace DPFacadeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisualForm form = new VisualForm(
                new TextBoxForm(),
                new ButtonForm(),
                new ListForm());

            form.Show();
            Console.WriteLine();
            form.Insert("item 1");
        }
    }
}