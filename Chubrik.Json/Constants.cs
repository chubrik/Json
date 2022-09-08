namespace Chubrik.Json;

using static Chubrik.Json.CharType;

internal static class Constants
{
    public static readonly CharType[] CharTypeMap = new[]
    {
        None,    None,    None,    None,    None,    None,    None,    None,
        None,    None,    None,    None,    None,    None,    None,    None,
        None,    None,    None,    None,    None,    None,    None,    None,
        None,    None,    None,    None,    None,    None,    None,    None,
        None,    None,    None,    None,    None,    None,    None,    None,    //    ! " # $ % & '
        None,    None,    None,    None,    None,    None,    None,    None,    //  ( ) * + , - . /
        Number,  Number,  Number,  Number,  Number,  Number,  Number,  Number,  //  0 1 2 3 4 5 6 7
        Number,  Number,  None,    None,    None,    None,    None,    None,    //  8 9 : ; < = > ?
        None,    LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, //  @ A B C D E F G
        LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, //  H I J K L M N O
        LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, LetterU, //  P Q R S T U V W
        LetterU, LetterU, LetterU, None,    None,    None,    None,    Underln, //  X Y Z [ \ ] ^ _
        None,    LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, //  ` a b c d e f g
        LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, //  h i j k l m n o
        LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, LetterL, //  p q r s t u v w
        LetterL, LetterL, LetterL                                               //  x y z
    };
}
