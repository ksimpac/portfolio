import java.util.Scanner;

public class Pokemon_Go_Ball
{
	
	static boolean result[] = new boolean[3];
	
	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		
	}
	
	public static void print(int level,int ball_level)
	{
		
	}
	
	public static void verify(int level)
	{
		
		boolean temp = level >= 1 && level <= 11;
		
		if (level >= 1 && level <= 30 && temp == true )
		{
			result[0] = true;
		}
		
		if (level >= 12 && level <= 30 && temp == false)
		{
			result[1] = true;
		}
		
		if (level >= 20 && level <= 30 && temp == false)
		{
			result[2] = true;
		}
		
	}

}