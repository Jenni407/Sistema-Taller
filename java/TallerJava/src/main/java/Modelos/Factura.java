/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Modelos;

/**
 *
 * @author Administrador
 */
public class Factura {
     private int id;
    private String cliente;
    private String fecha; // Se recomienda usar String si la fecha viene como texto ISO desde la API
    private double total;

    // Getters
    public int getId() { return id; }
    public String getCliente() { return cliente; }
    public String getFecha() { return fecha; }
    public double getTotal() { return total; }

    // Setters
    public void setId(int id) { this.id = id; }
    public void setCliente(String cliente) { this.cliente = cliente; }
    public void setFecha(String fecha) { this.fecha = fecha; }
    public void setTotal(double total) { this.total = total; }
}
