using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator
{
    private static Audio audio;

    public static void Provide(Audio _audio)
    {
        audio = _audio;
    }

    public static Audio getAudio()
    {
        return audio;
    }
}
