public interface IGameManager
{
    float Score { get; }
    //float ScoreNeeded { get; }
    //float MaxScore { get; }
    //bool MaxScoreReached { get; }
    int CurrentLevel { get; }
    //int CurrentBooster { get; }


    void Win();
    void Loose();


    void StartGame(int level);
    void SetLevel(int level);
    //void CatchedSponsor(int type, float value);
    void RestartGame();

    void StartPractice();
    void SetAudio();
}
