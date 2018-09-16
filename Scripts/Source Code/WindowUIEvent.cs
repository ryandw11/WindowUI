using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowUIEvent {

    /*
     * WindowUI API
     * Author: Ryandw11.
     * Version: 1.0
     */

    private int id;
    private int output;
    private WindowUIMenu wum;

    public WindowUIEvent(int id, int output, WindowUIMenu wum)
    {
        this.id = id;
        this.output = output;
        this.wum = wum;
    }

    /*
     * Grab the message's uniqueId.
     */
    public int getId()
    {
        return id;
    }


    /*
     * Grab the output value.
     */
    public int getOutput()
    {
        return output;
    }


    /*
     * Close the window.
     */
    public void close()
    {
        wum.close();
    }
}
