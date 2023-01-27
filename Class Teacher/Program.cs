public class Teacher
{
    private string name;
    private string subject;
    private int timeTeaching;
    private double teacherIncome;
    public Teacher(string name, string subject, int timeTeaching, double teacherIncome)
    {
        this.name = name;
        this.subject = subject;
        this.timeTeaching = timeTeaching;
        this.teacherIncome = teacherIncome;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetSubject()
    {
        return this.subject;
    }
    public int GetTimeTeaching()
    {
        return this.timeTeaching;
    }
    public double GetTeachingIncome()
    {
        return this.teacherIncome;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetSubject(string subject)
    {
        this.subject = subject;
    }
    public void SetTimeTeaching(int timeTeaching)
    {
        this.timeTeaching = timeTeaching;
    }
    public void SetTeacherIncome(double teacherIncome)
    {
        this.teacherIncome = teacherIncome;
    }
    //ctor end
    public bool isEquals(Teacher other)
    {
        if (other.name == this.name && other.subject == this.subject && other.timeTeaching == this.timeTeaching && other.teacherIncome == this.teacherIncome)
        {
            return true;
        }
        return false;
    }
    public string RankTeacherIncome(double defualtAvgIncome = 6530.69)
    {
        if (this.teacherIncome < defualtAvgIncome * 0.7)
        {
            return "Income <= 70% Below avrage";
        }
        else if (this.teacherIncome < defualtAvgIncome * 0.5)
        {
            return "Income <= 50% Below avrage";
        }
        else if (this.teacherIncome < defualtAvgIncome * 0.3)
        {
            return "Income <= 30% Below avrage";
        }
        else if (this.teacherIncome < defualtAvgIncome * 0.1)
        {
            return "Income <= 10% Below avrage";
        }
        else if (this.teacherIncome > defualtAvgIncome / 0.7)
        {
            return "Income >= 70% Above avrage";
        }
        else if (this.teacherIncome > defualtAvgIncome / 0.5)
        {
            return "Income >= 50% Above avrage";
        }
        else if (this.teacherIncome > defualtAvgIncome / 0.3)
        {
            return "Income >= 30% Above avrage";
        }
        else if (this.teacherIncome > defualtAvgIncome / 0.1)
        {
            return "Income >= 10% Above avrage";
        }
        else
        {
            return "Avrage income";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string name;
        string subject;
        int timeTeaching;
        double teacherIncome;
        EntrInfo();
        Teacher T1 = new Teacher(name, subject, timeTeaching, teacherIncome);
        Console.WriteLine("Enter avg teacher income or dont defualt is 6530.69");
        double avgIncome = double.Parse(Console.ReadLine());
        Console.WriteLine(T1.RankTeacherIncome(avgIncome));
        EntrInfo();
        Teacher T2 = new Teacher(name, subject, timeTeaching, teacherIncome);
        EntrInfo();
        Teacher T3 = new Teacher(name, subject, timeTeaching, teacherIncome);
        bool isEqual = T2.isEquals(T3);
        Console.WriteLine("Is teacher 2 equal to teacher 3??? y/n");
        string HahaTextBoxGoBrrrr = Console.ReadLine();
        if (isEqual)
        {
            Console.WriteLine("They are equal");
        }
        else
        {
            Console.WriteLine("They arent equal");
        }
        void EntrInfo()
        {
            Console.WriteLine("Enter teachers name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the teachers subject");
            subject = Console.ReadLine();
            Console.WriteLine("Enter the time the teacher is teaching");
            timeTeaching = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher income");
            teacherIncome = double.Parse(Console.ReadLine());
        }
    }
}
