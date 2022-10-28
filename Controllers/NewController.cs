/*
ARELY MARTINEZ 

OCT 24, 2022 5:02 PM 

MINI CHALLANGE #1

WELL CREATE MULTIPLE ROUTES AND METHOS ONE FOR 
EACH MINI CHALLANGE. IN PROGRAM YOULL BE ABLE TO 
CALL OUT BY ENTERING IN THE ROUTE NAME. EXAMPLE:
https://localhost:7274/new/SAYHELLO THIS WILL
 RESPOND WITH - HELLO ARELY GOOD EVENING!!
PEER REVIEW: Aisha Mashrah Everything seems to 
work. The methods were the correct names and 
there was a full discription of what was going 
on. The flowchart looks neat and represents the 
code too.

*/

using Microsoft.AspNetCore.Mvc;

namespace nweeeewapi.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet] 
    [Route("Hello")] 

    public string SayingHello() {
        return "SAYING HELLO - WHATS UR NAME?:    HELLO {ARELY}, GOOD MORNING !!";
    }

    [HttpGet] 
    [Route("Adding")] 

    public string AddingTwoNumbers() {
        return "LETS ADD TWO NUMBERS - ENTER 2 NUMBERS:    {4} + {9} = 13";
    }

    [HttpGet] 
    [Route("asking")] 

    public string AskingQuestions() {
        return "WHATS YOUR NAME?  WHAT TIME DID YOU WAKE?:    YOUR  NAME IS {ARELY} AND YOU WOKE UP AT {6 AM} ";
    }

    [HttpGet] 
    [Route("Greater")] 

    public string GreaterThanOrLessThan() {
        return "LETS COMPARE TWO NUMEBRS - ENTER 2 NUMBERS:  {6} > {19} & {19} > {6}";
    }

    [HttpGet] 
    [Route("MadLib")] 

    public string MadLibs() {
        return "LETS CREATE A SENTENCE - ENTER A CELEBRITY, SPORT, CAR, PLACE, COLOR, ANIMMAL , ADJECTIVE, A NAME, A RESTUARNT, UR FAV HOBBY:    WHILE YOU WERE TAKING A BREAK FROM {SOCCER} AND ABOUT TO DO YOUR FAV HOOBY OF {PAINTING TREES} YOU SEE {EMINEM} ARRIVED IN A {BLUE} {BUGGIE}. AS IF THATS NOT {SILLY} ENOUGH YOU SEE UR BEST FRIEND {KYLE} MUNCHING ON {MAC & CHEESE} NEXT TO HIM IS A RARE ONE OF A KIND {BABY MONKEY}. YOU GO UP TO {EMINEM} BECUASE YOUR HIS BIGGEST FAN AND END UP DINNING AT {DENNY'S} ";
    }

    [HttpGet] 
    [Route("Odd")] 

    public string OddOrEven() {
        return "IS THE NUMBER ODD OR EVEN - ENTER A NUMBER:    {7} IS ODD ";
    }

    [HttpGet] 
    [Route("Reverse")] 

    public string ReverseIt() {
        return "LETS REVERSE A STRING OF CHARACTERS:    ORIGINAL - 49FHFJ HI  REVERSE - HI JFHF94";
    }

    [HttpGet] 
    [Route("Magic")] 

    public string MagicEightBall() {
        return "ASK THE MAGIC BALL:    QUESTION: {WILL I GROW} ANSWER: ASK AGAIN LATER";
    }

    [HttpGet] 
    [Route("Res")] 

    public string Res() {
        return "LETS PICK A PLACE TO EAT - ENTER 'AMERICAN' 'MEXICAN' OR 'ITALIAN':    YOU CHOSE {MEXICAN}, LETS EAT AT LA ESTRELLA!!";
    }


}