public class Player
{
    private int _score;


    public Player()
    {
        _score = 0;
    }


    public void AddPoints(int points)
    {
        _score += points;
    }


    public int GetScore()
    {
        return _score;
    }


    public void SetScore(int score)
    {
        _score = score;
    }
}