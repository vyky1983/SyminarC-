using static System.Console;
Clear();

string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
       // res=nums[ost]+res;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}
Write(" =:");
int [] array = PrepareArray();
int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}



int [] PrepareArray(){
    Write(" array size, min, max: ");
    string [] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int [] arr = GetArray(Convert.ToInt32(parameters[0]),Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
    WriteLine($"[{String.Join(", ", arr)}]");
    return arr;
}
