public class Mercedes : Tasit
{
    public override void MotorGucu()
    {
        // Tasit sınıfı içerisindeki abstract olarak işaretlenmiş MotorGucu metodunu ezerek implementasyon yaptık!!
        throw new NotImplementedException();
    }
    public override void Sunroof()
    {
        Console.WriteLine("Mercedes sınıfına ait metot");
    }

}