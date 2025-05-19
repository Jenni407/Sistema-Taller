/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Servicio;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import Modelos.Servicio;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.List;


/**
 *
 * @author Administrador
 */
public class ServiceServicio {
     public List<Servicio> obtenerServicios() {
        try {
            URL url = new URL("http://localhost:5025/api/servicios");
            HttpURLConnection con = (HttpURLConnection) url.openConnection();
            con.setRequestMethod("GET");

            BufferedReader in = new BufferedReader(
                new InputStreamReader(con.getInputStream(), StandardCharsets.UTF_8)
            );

            String inputLine;
            StringBuilder respuesta = new StringBuilder();

            while ((inputLine = in.readLine()) != null) {
                respuesta.append(inputLine);
            }
            in.close();

            Gson gson = new Gson();
            return gson.fromJson(respuesta.toString(), new TypeToken<List<Servicio>>() {}.getType());

        } catch (Exception e) {
            e.printStackTrace();
            return Arrays.asList(); // Lista vacía en caso de error
        }
    }
}
