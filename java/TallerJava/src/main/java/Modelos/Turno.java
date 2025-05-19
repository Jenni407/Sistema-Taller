/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Modelos;

/**
 *
 * @author Administrador
 */
public class Turno {
    private int id_turno;
    private String fecha; 
    private String hora;
    private String cliente;
    private String vehiculo;
    private String servicio;
    private String estado;
    
    
    //Getter
    public int gerId_turno() {return id_turno;}
    public String getFecha() {return fecha;}
    public String getHora() {return hora;}
    public String getCliente() {return cliente;}
    public String getVehiculo() {return vehiculo;}
    public String getServicio() {return servicio;}
    public String getEstado() {return estado;}
    
    //Setter
    public void setId_turno (int id_turno) {this.id_turno = id_turno;}
    public void setFecha (String fecha) {this.fecha = fecha;}
    public void setHora (String hora) {this.hora = hora;}
    public void setCliente (String cliente) {this.cliente = cliente;}
    public void setVehiculo (String vehiculo) {this.vehiculo = vehiculo;}
    public void setServicio (String servicio) {this.servicio = servicio;}
    public void setEstado (String estado) {this.estado = estado;}
}
