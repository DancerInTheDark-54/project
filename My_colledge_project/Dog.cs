using System;

public class Dog
{
    private int height;
    private int score;
    private int health;
    private int speed;
    public Dog(int height)
	{
        this.height = height;
        this.health = 100;
        this.score = 0;
        this.speed = 0;
	}
    public void move()
    {
        this.speed = 10;
    }




}
