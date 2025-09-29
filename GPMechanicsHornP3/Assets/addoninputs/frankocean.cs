using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public float spinSpeed = 90f; // degrees per second

    void Start()
    {
        Debug.Log("yo fam let me dig in yo butt twin");
        Debug.Log("All I ever wanted was a Black Grand National\r\n- bein' rational, give 'em what they ask for\r\nThere's not enough (ay)\r\nFew solid - left, but it's not enough\r\nFew - that'll really step, but it's not enough\r\nSay you bigger than myself, but it's not enough (huh)\r\nI get on they -, yeah, somebody gotta do it\r\nI make 'em - mad, yeah, somebody gotta do it\r\nI take a G-pass, yeah, watch a - do it (huh)\r\nWe survived outside, all from the music, -, what?\r\nThey like, \"What he on?\"\r\nIt's the Alpha and Omega, -, welcome home\r\nThis is not a song\r\nThis a revelation, \"How to get a - gone\"\r\nYou need your man, baby, I don't wanna slam, baby\r\nPay your bill and make you feel protected like I can, baby\r\nTeach you somethin' if you need correction, that's the plan, baby\r\nDon't put your life in these weird - hands, baby (wop)\r\nThere's not enough (ay)\r\nFew solid - left, but it's not enough\r\nFew - that'll really step, but it's not enough\r\nSay you bigger than myself, but it's not enough (huh)\r\nI get on they -, yeah, somebody gotta do it\r\nI make 'em - mad, yeah, somebody gotta do it\r\nI take a G-pass, yeah, watch a - do it (huh)\r\nWe survived outside, all from the music, -, what?\r\nHey, turn this TV off\r\nAin't with my type activities? Then don't you get involved\r\nHey, what, huh, how many - I seen? Seen 'em all\r\nTake a rest or take a trip, you know I'm trippin' for my dawg\r\nWho you with? Couple sergeants and lieutenants for the get-back\r\nThis revolution been televised, I fell through with the knick-knacks\r\nHey, young -, get your chili up, yeah, I meant that\r\nHey, blackout if they act out, yeah, I did that\r\nHey, what's up, dawg?\r\nI hate a - that's hatin' on a - and they both -\r\nI hate a - hatin' on 'em - and they both broke\r\nIf you ain't comin' for no chili, what you come for?\r\n- feel like he entitled 'cause he knew me since a kid\r\n-, I cut my granny off, if she won't see it how I see it\r\nHm, got a big mouth, but he lack big ideas\r\nSend him to the moon, that's just how I feel yellin'\r\nThere's not enough (ay)\r\nFew solid - left, but it's not enough\r\nFew - that'll really step, but it's not enough\r\nSay you bigger than myself, but it's not enough\r\nHuh, huh, huh\r\nHey, hey (Mustard on the beat, -)\r\nMustard\r\n- actin' bad, but somebody gotta do it\r\nGot my foot up on the gas, but somebody gotta do it\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\nAin't no other king in this rap thing, they siblings\r\nNothin' but my children, one shot, they disappearin'\r\nI'm in a city where the flag be gettin' thrown like it was\r\nPass interference, padlock around the buildin'\r\nCrash, pullin' up in a marked truck just to play freeze tag\r\nWith a bone to pick, like it was sea bass\r\nSo when I made it out, I made about 50K from a show\r\nTryna show - the ropes before they hung from a rope\r\nI'm prophetic, they only talk about it, I get it\r\nOnly good for savin' face, seen the cosmetics\r\nHow many heads I gotta take to level my aesthetics?\r\nHurry up and get your muscle up, we out to plyometric\r\n- ran up out of luck soon as I up the highest metric\r\nThe city just made it sweet, you could die, I bet it\r\nThey mouth get full of deceit, let these cowards tell it\r\nWalk in New Orleans with the etiquette of LA, yellin'\r\nMustard (oh, man)\r\n- actin' bad, but somebody gotta do it\r\nGot my foot up on the gas, but somebody gotta do it\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\nHuh, turn this TV off, turn this TV off\r\n- gets crazy, scary, spooky, hilarious\r\nCrazy, scary, spooky, hilarious\r\n- gets crazy, scary, spooky, hilarious\r\nCrazy, scary, spooky, hilarious\r\n- gets crazy, scary, spooky, hilarious\r\nCrazy, scary, spooky, hilarious\r\n- gets crazy, scary, spooky, hilarious\r\nCrazy, scary, spooky, hilarious");
    }

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // Get input from WASD or arrow keys
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            horizontal = -1f;
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            horizontal = 1f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            vertical = 1f;
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            vertical = -1f;

        // Apply rotation: left/right = Y axis, up/down = X axis
        transform.Rotate(Vector3.up, horizontal * spinSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right, -vertical * spinSpeed * Time.deltaTime, Space.Self);
    }
}