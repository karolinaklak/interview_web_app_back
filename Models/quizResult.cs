public class QuizResult {
    public int Id { get; set; }
    
    public int QuizId { get; set; }
    public int QuestionId { get; set; }
    public required string Answer { get; set; }
    public required string Comment { get; set; }
    public int TimePassed { get; set; }
}