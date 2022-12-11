namespace Chubrik.Json;

using static Chubrik.Json.CharType;

internal static class Constants
{
    public static readonly CharType[] CharTypeMap = new[]
    {
        Other, Other, Other, Other, Other, Other, Other, Other,
        Other, Other, Other, Other, Other, Other, Other, Other,
        Other, Other, Other, Other, Other, Other, Other, Other,
        Other, Other, Other, Other, Other, Other, Other, Other,
        Other, Other, Other, Other, Other, Other, Other, Other,  //    ! " # $ % & '
        Other, Other, Other, Other, Other, Other, Other, Other,  //  ( ) * + , - . /
        Other, Other, Other, Other, Other, Other, Other, Other,  //  0 1 2 3 4 5 6 7
        Other, Other, Other, Other, Other, Other, Other, Other,  //  8 9 : ; < = > ?
        Other, Upper, Upper, Upper, Upper, Upper, Upper, Upper,  //  @ A B C D E F G
        Upper, Upper, Upper, Upper, Upper, Upper, Upper, Upper,  //  H I J K L M N O
        Upper, Upper, Upper, Upper, Upper, Upper, Upper, Upper,  //  P Q R S T U V W
        Upper, Upper, Upper, Other, Other, Other, Other, ULine,  //  X Y Z [ \ ] ^ _
        Other, Lower, Lower, Lower, Lower, Lower, Lower, Lower,  //  ` a b c d e f g
        Lower, Lower, Lower, Lower, Lower, Lower, Lower, Lower,  //  h i j k l m n o
        Lower, Lower, Lower, Lower, Lower, Lower, Lower, Lower,  //  p q r s t u v w
        Lower, Lower, Lower, Other, Other, Other, Other, Other   //  x y z { | } ~
    };
}
