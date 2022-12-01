using System.Collections.Generic;

namespace QuizClient.Tests;

public struct Answer
{
    public int id { get; set; }
    public string text { get; set; }
}

public struct Question
{
    public int id { get; set; }
    public string text { get; set; }
    public List<Answer> answers { get; set; }
    public int correctAnswerId { get; set; }
    public int actualAnswerId { get; set; }
}

public struct QuestionResponse
{
    public int id { get; set; }
    public string title { get; set; }
    public List<Question> questions { get; set; }
}