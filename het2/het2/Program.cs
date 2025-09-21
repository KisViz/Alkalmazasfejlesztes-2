//double variable = 3.14;
//double another = variable;
//another = 2.72;

//Console.WriteLine(variable); // 3.14

//class RefType
//{
//    public double valueType;
//}
// ...

class Program
{
    static void Main(string[] args)
    {
        //RefType rt = new RefType();
        //rt.valueType = 3.14;

        //RefType another = rt;
        //another.valueType = 2.71;

        //Console.WriteLine(rt.valueType); // 2.71





        //int? nullableInt = null;
        //Nullable<int> anotherNullable = null;

        //if (nullableInt.HasValue)
        //    Console.WriteLine(nullableInt.Value);

        //if (anotherNullable == null)
        //    anotherNullable = 3;

        //Console.WriteLine(anotherNullable.Value); // 3





        private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


}
}
