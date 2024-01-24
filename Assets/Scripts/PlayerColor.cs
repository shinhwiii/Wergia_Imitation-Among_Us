using System.Collections.Generic;
using UnityEngine;

public enum EPlayerColor
{
    Red, Blue, Green,
    Pink, Orange, Yellow,
    Black, White, Purple,
    Brown, Cyan, Lime
}

public class PlayerColor
{
    private static List<Color> colors = new List<Color>()
    {
        new Color(1f, 0f, 0f),
        new Color(0.1f, 0.1f, 1f),
        new Color(0f, 0.6f, 0f),
        new Color(1f, 0.3f, 0.9f),
        new Color(1f, 0.4f, 0f),
        new Color(1f, 0.9f, 0.1f),
        new Color(0.2f, 0.2f, 0.2f),
        new Color(0.9f, 1f, 1f),
        new Color(0.6f, 0f, 0.6f),
        new Color(0.7f, 0.2f, 0f),
        new Color(0f, 1f, 1f),
        new Color(0.1f, 1f, 0.1f)
    };

    public static Color GetColor(EPlayerColor playerColor) { return colors[(int)playerColor]; }
    public Color Red { get { return colors[(int)EPlayerColor.Red]; } }
    public Color Blue { get { return colors[(int)EPlayerColor.Blue]; } }
    public Color Green { get { return colors[(int)EPlayerColor.Green]; } }
    public Color Pink { get { return colors[(int)EPlayerColor.Pink]; } }
    public Color Orange { get { return colors[(int)EPlayerColor.Orange]; } }
    public Color Yellow { get { return colors[(int)EPlayerColor.Yellow]; } }
    public Color Black { get { return colors[(int)EPlayerColor.Black]; } }
    public Color White { get { return colors[(int)EPlayerColor.White]; } }
    public Color Purple { get { return colors[(int)EPlayerColor.Purple]; } }
    public Color Brown { get { return colors[(int)EPlayerColor.Brown]; } }
    public Color Cyan { get { return colors[(int)EPlayerColor.Cyan]; } }
    public Color Lime { get { return colors[(int)EPlayerColor.Lime]; } }

}
