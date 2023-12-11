namespace BattleShipGame.Models;

public class Bullet
{
    public Image bImage;
    public Point p;
    public int height, width;
    public int speed;
    public Bullet(int px, int py)
    {
        this.p.X = px;
        this.p.Y = py;
           
            
    }
    public void Move()
    {
        this.p.Y += speed;
    }
}