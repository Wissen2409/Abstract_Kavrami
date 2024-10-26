// abstract bir sınıf üretelim 


// içerisindeki tek bir absract üye olan sınıf da abstract olarak işaretlenmek zorundadır!!!
public abstract class Tasit{

    // iki türlü metot yazılabilir

    // Abstract metot 
    // Virtual metot 

    //Abstract metotlar : Tasit abstract sınıfını kullanan bir sınıfın mecburen implement etmesi gerken bir metot olmaktadır

    public abstract void MotorGucu();

    
    // Absract metotların gövdesi yoktur!! Bu metot tasit sınıfını katılım alan diğer sınıftalarda mevburen kullanılması
    //(override)ezilmesi gerekmektedir!!!

    public virtual void Sunroof(){

        Console.WriteLine("Taşıt sınıfına ait metot");
    }
    // Virtual metotlarda metot gövdesi olur!!!
    // Tasit sınıfından türeyen sınıflarda, virtual metotun override edilmesi zorunlu değildir
    // etmek isterseniz edebilirsiniz!!!

}