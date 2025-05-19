/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Modelos;

/**
 *
 * @author Administrador
 */
public class Vehiculo {
    
    private int id;
    private String marca;
    private String modelo;
    private String color;
    private String placa;

    // Getters
    public int getId() { return id; }
    public String getMarca() { return marca; }
    public String getModelo() { return modelo; }
    public String getColor() { return color; }
    public String getPlaca() { return placa; }

    // Setters
    public void setId(int id) { this.id = id; }
    public void setMarca(String marca) { this.marca = marca; }
    public void setModelo(String modelo) { this.modelo = modelo; }
    public void setColor(String color) { this.color = color; }
    public void setPlaca(String placa) { this.placa = placa; }
}
