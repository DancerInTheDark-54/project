using System;

public class Dog
{
    private int height;
    private int score;
    private int health;
    private int speed;
    private int hunger;
    public Dog(int height)
	{
        this.height = height;
        this.health = 100;
	this.hunger = 100;
        this.score = 0;
        this.speed = 0;
	}
    public void move()
    {
        this.speed = 10;
    }
	
	public void hungering()
	{
	 
	}
        public void jump()
	{
	
	}



}
