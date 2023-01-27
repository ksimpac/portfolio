package com.example.adasl.practice1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.content.Intent;

public class MainActivity extends AppCompatActivity {

    Intent intent = new Intent();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setTitle("First Page");
        Button Next = (Button)findViewById(R.id.btn_next);
        Next.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                intent.setClass(MainActivity.this,Second_page.class);
                startActivity(intent);
                setContentView(R.layout.page2);
                MainActivity.this.finish();
            }
        });
    }
}
