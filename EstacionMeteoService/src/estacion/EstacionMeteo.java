package estacion;

import java.io.Serializable;
import java.rmi.*;
import java.rmi.server.*;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.File;
import java.util.Scanner;
import java.io.FileWriter;

public class EstacionMeteo extends UnicastRemoteObject implements Serializable
{
	private static final long serialVersionUID = 1L;
	//Parametros
    private int temp;
    private int hum;
    private int lum;
    private String pantalla;
    private String NArchivo;
    

    //Constructor
    public EstacionMeteo (String Archivo) throws RemoteException, FileNotFoundException, IOException
    {
        NArchivo=Archivo+".txt";
        int[] Contenido=muestraContenido(NArchivo);
        temp=Contenido[0];
        hum=Contenido[1];
        lum=Contenido[2];
        pantalla="";
    }

    //getters y setters
    public int getTemperatura()
    {
        return temp;
    }
    
    public int getHumedad()
    {
        return hum;
    }
    
    public int getLuminosidad()
    {
        return lum;
    }
    
    public String getPantalla()
    {
        return pantalla;
    }
    
    public String setTemperatura(int newTemp)
    {
        String msg;
        int[] valores=new int[3];
        if(newTemp>=-30 && newTemp<=50)
        {
            temp=newTemp;
            
            msg="Valor de Temperatura modificado a "+newTemp+" con exito.\n";
            valores=Lectura("Temperatura", newTemp);
            Modifica(valores);
        }
        else
        {
            msg="Valor de temperatura fuera de rango. Introduzca un valor entre -30 y 50\n";
        }
        return msg;
    }
    
    public String setHumedad(int newHum)
    {
        String msg;
        int[] valores=new int[3];
        if(newHum>=0 && newHum<=100)
        {
            hum=newHum;
            msg="Valor de Humedad modificado a "+newHum+" con exito.\n";
            valores=Lectura("Humedad", newHum);
            Modifica(valores);
        }
        else
        {
            msg="Valor de humedad fuera de rango. Introduzca un valor entre 0 y 100\n";
        }
        return msg;
    }
    
    public String setLuminosidad(int newLum)
    {
        String msg;
        int[] valores=new int[3];
        if(newLum>=0 && newLum<=800)
        {
            lum=newLum;
            msg="Valor de luminosidad modificado a "+newLum+" con exito.\n";
            valores=Lectura("Luminosidad", newLum);
            Modifica(valores);
        }
        else
        {
            msg="Valor de luminosidad fuera de rango. Introduzca un valor entre 0 y 800.\n";
        }
        return msg;
    }
    
    public String setMsg(String newMsg)
    {
        String msg;
        if(newMsg.length()<=150)
        {
            pantalla=newMsg;
            msg="Mensaje cambiado correctamente.\n";
        }
        else
        {
            msg="Valor de mensaje demasiado largo.Introduzca un mensaje de menos de 150 caracteres.\n";
        }
        return msg;
    } 

     public int[] muestraContenido(String archivo) throws FileNotFoundException, IOException, RemoteException 
     {
        int[] valores=new int[3];
        int i=0;
        String cadena;
        FileReader f = new FileReader(archivo);
        BufferedReader b = new BufferedReader(f);
        while((cadena = b.readLine())!=null) {
            valores[i]=Integer.parseInt(cadena.split("=")[1]);
            i++;
        }
        b.close();
        return valores;
    }
      ////////////////////////////////////
     //FUNCIONES DE LECTURA Y ESCRITURA//
    ////////////////////////////////////
    public int[] Lectura(String Atributo, int nValor) {

        // Fichero del que queremos leer
        int[] valores=new int[3];
        int i=0;
        File fichero = new File(NArchivo);
        Scanner s = null;

        try {
            // Leemos el contenido del fichero
            s = new Scanner(fichero);

            // Leemos linea a linea el fichero
            while (s.hasNextLine()) {
                String linea = s.nextLine();    // Guardamos la linea en un String
                if(linea.split("=")[0].equals(Atributo))
                {
                    valores[i]=nValor;
                    i++;
                }
                else
                {
                    valores[i]=Integer.parseInt(linea.split("=")[1]);
                    i++;
                }
            }

        } catch (Exception ex) {
            System.out.println("Mensaje: " + ex.getMessage());
        } finally {
            // Cerramos el fichero tanto si la lectura ha sido correcta o no
            try {
                if (s != null)
                    s.close();
            } catch (Exception ex2) {
                System.out.println("Mensaje 2: " + ex2.getMessage());
            }
        }
        return valores;
    }

    public void Modifica(int[] valores) {
        String[] lineas = { "Temperatura="+valores[0], "Humedad="+valores[1], "Luminosidad="+valores[2] };

        FileWriter fichero = null;
        try {

            fichero = new FileWriter(NArchivo);

            // Escribimos linea a linea en el fichero
            for (String linea : lineas) {
                fichero.write(linea + "\n");
            }

            fichero.close();

        } catch (Exception ex) {
            System.out.println("Mensaje de la excepción: " + ex.getMessage());
        }
    }
}
