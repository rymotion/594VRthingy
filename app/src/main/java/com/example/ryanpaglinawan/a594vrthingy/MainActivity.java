package com.example.ryanpaglinawan.a594vrthingy;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class MainActivity extends Activity {
        private String TAG = "Plug.StartActivity";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.d(TAG, "Activity created");
        setContentView(R.layout.activity_main);

    }
    public static void Call(Activity activity){
        //  Start Unity Activity
        Intent myIntent = new Intent(activity, MainActivity.class);
        activity.startActivity(myIntent);
    }
    public static void getScore(Int score){
        // Should modify text field to be the score from the game
    }
}

