using System;

public class Car
{
	string[] Name=new string[10];
	string[] num = new string[10];
	int[] model=new int[10];
    int[] seats=new int[10];
	int index=0
    public Car(string name,string num,int model,int seats)
    {
		this.Name[index] = name;
		this.num[index] = num;
		this.model[index] = model;
		this.seats[index] = seats;
		index++;
    }
    public void add(string name, string num, int model, int seats)
    {
		int check=find(num);
		if (check != -1)
		{
			this.Name[index] = name;
			this.num[index] = num;
			this.model[index] = model;
			this.seats[index] = seats;
			index++;
		}
		else
		{
            Console.WriteLine("car with same number exit")

        }
    }
    public void info()
	{
		Console.WriteLine("enter a number of car ");
	     int number = Console.Readline();
        int i = find(number);
		if(i!=-1)
		{
			Console.WriteLine("Name " + Name[i] + " number " + num[i] + " model " + model[i] + " seats " + seats[i]);

        }
		else
		{
		    Console.WriteLine("no car found");
		}
	}
	private int find(int number)
	{
		if (index == 0)
		{ return -1; }
		for(int count=0; count<num.Length; count++)
		{
			if(num[count] == number)
			{
				return count;
			}
		}
		return -1;
	}
}
public class Class1
{
	static void Main()
	{
		Car car = new Car("civic","ay-234",2010,4);
		car.info();
	}
}
