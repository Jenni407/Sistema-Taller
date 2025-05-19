/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Modelos;

/**
 *
 * @author Administrador
 */
public class Taller {
     private String id;
    private String nombre;
    private String direccion;
    private String telefono;
    private String email;
    private String horario;
    private String servicios;

    // Getters
    public String getId() { return id; }
    public String getNombre() { return nombre; }
    public String getDireccion() { return direccion; }
    public String getTelefono() { return telefono; }
    public String getEmail() { return email; }
    public String getHorario() { return horario; }
    public String getServicios() { return servicios; }

    // Setters
    public void setId(String id) { this.id = id; }
    public void setNombre(String nombre) { this.nombre = nombre; }
    public void setDireccion(String direccion) { this.direccion = direccion; }
    public void setTelefono(String telefono) { this.telefono = telefono; }
    public void setEmail(String email) { this.email = email; }
    public void setHorario(String horario) { this.horario = horario; }
    public void setServicios(String servicios) { this.servicios = servicios; }
}
