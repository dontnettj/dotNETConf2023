var studentDto = new StudentDto("Dilshod", 1);

var name = studentDto.Name;
var id = studentDto.Id;

record StudentDto(string Name, int Id)
{

}