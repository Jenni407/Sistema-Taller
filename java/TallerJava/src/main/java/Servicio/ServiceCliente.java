/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Servicio;

import Modelos.Cliente;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import java.util.ArrayList;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.lang.reflect.Type;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;
import java.util.List;

public class ServiceCliente {

    public static List<Cliente> obtenerTodosLosClientes() {
   try {
    URL url = new URL("http://localhost:5025/api/clientes");
    HttpURLConnection conn = (HttpURLConnection) url.openConnection();
    conn.setRequestMethod("GET");

    BufferedReader in = new BufferedReader(
                new InputStreamReader(conn.getInputStream(), StandardCharsets.UTF_8)
        );
            String inputLine;
            StringBuilder respuesta = new StringBuilder();

            while ((inputLine = in.readLine()) != null) {
                respuesta.append(inputLine);
            }
            in.close();

            // Usamos Gson para convertir JSON a lista de objetos
            Gson gson = new Gson();
            return gson.fromJson(respuesta.toString(), new TypeToken<List<Cliente>>() {}.getType());

        } catch (Exception e) {
            e.printStackTrace();
            return Arrays.asList(); // Devuelve lista vacía en caso de error
        }
    }

    
}

    