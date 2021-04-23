using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Datos_Personales
    {
        public static ML.Response.Datos_PersonalesResponse GetAll()
        {
            ML.Response.Datos_PersonalesResponse response = new ML.Response.Datos_PersonalesResponse();
            try
            {
                using(DL.DisponibilidadEntities3 context = new DL.DisponibilidadEntities3())
                {
                    var GetAll = context.SP_Datos_Personales_GetAll().ToList();
                    
                    if (GetAll != null)
                    {

                        response.Code = 100;
                        response.Message = "Mapeo Exitos;";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();

                        foreach (var obj in GetAll)
                        {
                            ML.Entities.Datos_Personales datos_Personales_Item = new ML.Entities.Datos_Personales();
                            datos_Personales_Item.Id_Datos_Personales = obj.Id_Datos_Personales;
                            datos_Personales_Item.Nombre = obj.Nombre;
                            datos_Personales_Item.APaterno = obj.APaterno;
                            datos_Personales_Item.AMaterno = obj.AMaterno;
                            datos_Personales_Item.Edad = obj.Edad;
                            datos_Personales_Item.Lugar_de_Nacimiento = obj.Lugar_de_Nacimiento;
                            datos_Personales_Item.Estado_Civil = obj.Estado_Civil;
                            datos_Personales_Item.CURP = obj.CURP;
                            datos_Personales_Item.Direccion = obj.Direccion;
                            datos_Personales_Item.Numero_Casa = obj.Numero_Casa;
                            datos_Personales_Item.Numero_Celular = obj.Numero_Celular;
                            datos_Personales_Item.Nombre_Licenciatura = obj.Nombre_Licenciatura;
                            datos_Personales_Item.Institucion_Lic = obj.Institucion_Lic;
                            datos_Personales_Item.Periodo_Lic = obj.Periodo_Lic;
                            datos_Personales_Item.Año_Titulacion_Lic = obj.Año_Titulacion_Lic;
                            datos_Personales_Item.Nombre_Maestria = obj.Nombre_Maestria;
                            datos_Personales_Item.Institucion_Mae = obj.Institucion_Mae;
                            datos_Personales_Item.Periodo_Mae = obj.Periodo_Mae;
                            datos_Personales_Item.Año_Titulacion_Mae = obj.Año_Titulacion_Mae;
                            datos_Personales_Item.Nombre_Doctorado = obj.Nombre_Doctorado;
                            datos_Personales_Item.Institucion_Doc = obj.Institucion_Doc;
                            datos_Personales_Item.Periodo_Doc = obj.Periodo_Doc;
                            datos_Personales_Item.Año_Titulacion_Doc = obj.Años_Titulacion_Doc;
                            datos_Personales_Item.Nombre_Especializacion = obj.Año_Titulacion_Espe;
                            datos_Personales_Item.Institucion_Espe = obj.Institucion_Espe;
                            datos_Personales_Item.Periodo_Espe = obj.Periodo_Espe;
                            datos_Personales_Item.Año_Titulacion_Espe = obj.Año_Titulacion_Espe;
                            datos_Personales_Item.Nombre_Curso = obj.Nombre_Curso;
                            datos_Personales_Item.Instituto_Curso = obj.Institucion_Curso;
                            datos_Personales_Item.Horas = obj.Horas;
                            datos_Personales_Item.Fecha = obj.Fecha;
                            datos_Personales_Item.Idioma = obj.Idioma;
                            datos_Personales_Item.Habla = obj.Habla;
                            datos_Personales_Item.Lee = obj.Lee;
                            datos_Personales_Item.Escribe = obj.Escribe;
                            datos_Personales_Item.Dominio = obj.Dominio;
                            datos_Personales_Item.Actividad_Puesto = obj.Actividad_Puesto;
                            datos_Personales_Item.Organizacion_Empresa = obj.Organizacion_Empresa;
                            datos_Personales_Item.Periodo = obj.Periodo;
                            datos_Personales_Item.Actividad_Puesto2 = obj.Actividad_Puesto2;
                            datos_Personales_Item.Organizacion_Empresa2 = obj.Organizacion_Empresa2;
                            datos_Personales_Item.Periodo2 = obj.Periodo2;
                            datos_Personales_Item.Actividad_Puesto3 = obj.Actividad_Puesto3;
                            datos_Personales_Item.Organizacion_Empresa3 = obj.Organizacion_Empresa3;
                            datos_Personales_Item.Periodo3 = obj.Periodo3;
                            datos_Personales_Item.Actividad_Puesto_Aca = obj.Actividad_Puesto_Aca;
                            datos_Personales_Item.Institucion_Aca = obj.Institucion_Aca;
                            datos_Personales_Item.Periodo_Aca = obj.Periodo_Aca;
                            datos_Personales_Item.Actividad_Puesto_Aca2 = obj.Actividad_Puesto_Aca2;
                            datos_Personales_Item.Institucion_Aca2 = obj.Institucion_Aca2;
                            datos_Personales_Item.Periodo_Aca2 = obj.Periodo_Aca2;
                            datos_Personales_Item.Actividad_Puesto_Aca3 = obj.Actividad_Puesto_Aca3;
                            datos_Personales_Item.Institucion_Aca3 = obj.Institucion_Aca3;
                            datos_Personales_Item.Periodo_Aca3 = obj.Periodo_Aca3;
                            datos_Personales_Item.Ingenieria_Industrial = obj.Ingenieria_Idustrial;
                            datos_Personales_Item.Ingenieria_Sistemas = obj.Ingenieria_Sistemas;
                            datos_Personales_Item.Tics = obj.Tics;
                            datos_Personales_Item.Ingenieria_Gestion = obj.Ingenieria_Gestion;
                            datos_Personales_Item.Ingenieria_Logistica = obj.Ingenieria_Logistica;
                            datos_Personales_Item.Ingenieria_Industial_Dis = obj.Ingenieria_Industrial_Dis;
                            datos_Personales_Item.Contador = obj.Contador;
                            datos_Personales_Item.Ingenieria_Mecatronica = obj.Ingenieria_Mecatronica;
                            datos_Personales_Item.Ingenieria_Gestion_Dis = obj.Ingenieria_Gestion_Dis;
                            datos_Personales_Item.Ingenieria_Administracion = obj.Ingenieria_Administracion;
                            datos_Personales_Item.Nombre_Materia_Ant = obj.Nombre_Materia_Ant;
                            datos_Personales_Item.Carrera_Ant = obj.Carrera_Ant;
                            datos_Personales_Item.Semestre_Ant = obj.Semestre_Ant;
                            datos_Personales_Item.Nombre_Materia_Ant2 = obj.Nombre_Materia_Ant2;
                            datos_Personales_Item.Carrera_Ant2 = obj.Carrera_Ant2;
                            datos_Personales_Item.Semestre_Ant2 = obj.Semestre_Ant2;
                            datos_Personales_Item.Nombre_Materia_Ant3 = obj.Nombre_Materia_Ant3;
                            datos_Personales_Item.Carrera_Ant3 = obj.Carrera_Ant3;
                            datos_Personales_Item.Semestre_Ant3 = obj.Semestre_Ant3;
                            datos_Personales_Item.Nombre_Materia_Ant4 = obj.Nombre_Materia_Ant4;
                            datos_Personales_Item.Carrera_Ant4 = obj.Carrera_Ant4;
                            datos_Personales_Item.Semestre_Ant4 = obj.Semestre_Ant4;
                            datos_Personales_Item.Nombre_Materia_Ant5 = obj.Nombre_Materia_Ant5;
                            datos_Personales_Item.Carrera_Ant5 = obj.Carrera_Ant5;
                            datos_Personales_Item.Semestre_Ant5 = obj.Semestre_Ant5;
                            datos_Personales_Item.Nombre_Materia_Ant6 = obj.Nombre_Materia_Ant6;
                            datos_Personales_Item.Carrera_Ant6 = obj.Carrera_Ant6;
                            datos_Personales_Item.Semestre_Ant6 = obj.Semestre_Ant6;
                            datos_Personales_Item.Nombre_Materia_Ant7 = obj.Nombre_Materia_Ant7;
                            datos_Personales_Item.Carrera_Ant7 = obj.Carrera_Ant7;
                            datos_Personales_Item.Semestre_Ant7 = obj.Semestre_Ant7;
                            datos_Personales_Item.Nombre_Materia_Ant8 = obj.Nombre_Materia_Ant8;
                            datos_Personales_Item.Carrera_Ant8 = obj.Carrera_Ant8;
                            datos_Personales_Item.Semestre_Ant8 = obj.Semestre_Ant8;
                            datos_Personales_Item.Nombre_Materia_Ant9 = obj.Nombre_Materia_Ant9;
                            datos_Personales_Item.Carrera_Ant9 = obj.Carrera_Ant9;
                            datos_Personales_Item.Semestre_Ant9 = obj.Semestre_Ant9;
                            datos_Personales_Item.Nombre_Materia_Imp = obj.Nombre_Materia_Imp;
                            datos_Personales_Item.Carrera_Imp = obj.Carrera_Imp;
                            datos_Personales_Item.Semestre_Imp = obj.Semestre_Imp;
                            datos_Personales_Item.Nombre_Materia_Imp2 = obj.Nombre_Materia_Imp2;
                            datos_Personales_Item.Carrera_Imp2 = obj.Carrera_Imp2;
                            datos_Personales_Item.Semestre_Imp2 = obj.Semestre_Imp2;
                            datos_Personales_Item.Nombre_Materia_Imp3 = obj.Nombre_Materia_Imp3;
                            datos_Personales_Item.Carrera_Imp3 = obj.Carrera_Imp3;
                            datos_Personales_Item.Semestre_Imp3 = obj.Semestre_Imp3;
                            datos_Personales_Item.Nombre_Materia_Imp4 = obj.Nombre_Materia_Imp4;
                            datos_Personales_Item.Carrera_Imp4 = obj.Carrera_Imp4;
                            datos_Personales_Item.Semestre_Imp4 = obj.Semestre_Imp4;
                            datos_Personales_Item.Nombre_Materia_Imp5 = obj.Nombre_Materia_Imp5;
                            datos_Personales_Item.Carrera_Imp5 = obj.Carrera_Imp5;
                            datos_Personales_Item.Semestre_Imp5 = obj.Semestre_Imp5;
                            datos_Personales_Item.Nombre_Materia_Imp6 = obj.Nombre_Materia_Imp6;
                            datos_Personales_Item.Carrera_Imp6 = obj.Carrera_Imp6;
                            datos_Personales_Item.Semestre_Imp6 = obj.Semestre_Imp6;
                            datos_Personales_Item.Nombre_Materia_Imp7 = obj.Nombre_Materia_Imp7;
                            datos_Personales_Item.Carrera_Imp7 = obj.Carrera_Imp7;
                            datos_Personales_Item.Semestre_Imp7 = obj.Semestre_Imp7;
                            datos_Personales_Item.Nombre_Materia_Imp8 = obj.Nombre_Materia_Imp8;
                            datos_Personales_Item.Carrera_Imp8 = obj.Carrera_Imp8;
                            datos_Personales_Item.Semestre_Imp8 = obj.Semestre_Imp8;
                            datos_Personales_Item.Nombre_Materia_Imp9 = obj.Nombre_Materia_Imp9;
                            datos_Personales_Item.Carrera_Imp9 = obj.Carrera_Imp9;
                            datos_Personales_Item.Semestre_Imp9 = obj.Semestre_Imp9;
                            datos_Personales_Item.Nombre_Materia_Imp10 = obj.Nombre_Materia_Imp10;
                            datos_Personales_Item.Carrera_Imp10 = obj.Carrera_Imp10;
                            datos_Personales_Item.Semestre_Imp10 = obj.Semestre_Imp10;
                            response.Datos_PersonalesList.Add(datos_Personales_Item);


                        }

                        return response;

                    }
                    
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al buscar";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                        return response;



                    }


                }



            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta Con Sistemas" + ex;
                response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                return response;
            }


        }

        public static ML.Response.Datos_PersonalesResponse Add(ML.Entities.Datos_Personales datos_Personales)
        {
            ML.Response.Datos_PersonalesResponse response = new ML.Response.Datos_PersonalesResponse();
            try
            {
                using (DL.DisponibilidadEntities3 context = new DL.DisponibilidadEntities3())
                {
                    var Add = context.SP_Datos_Personales_Add(datos_Personales.Nombre, datos_Personales.APaterno, datos_Personales.AMaterno,
           datos_Personales.Edad,
          datos_Personales.Lugar_de_Nacimiento,
           datos_Personales.Estado_Civil,
           datos_Personales.CURP,
           datos_Personales.Direccion,
           datos_Personales.Numero_Casa,
           datos_Personales.Numero_Celular,
           datos_Personales.Nombre_Licenciatura,
           datos_Personales.Institucion_Lic,
           datos_Personales.Periodo_Lic,
           datos_Personales.Año_Titulacion_Lic,
           datos_Personales.Nombre_Maestria,
           datos_Personales.Institucion_Mae,
           datos_Personales.Periodo_Mae,
           datos_Personales.Año_Titulacion_Mae,
           datos_Personales.Nombre_Doctorado,
           datos_Personales.Institucion_Doc,
           datos_Personales.Periodo_Doc,
           datos_Personales.Año_Titulacion_Doc,
           datos_Personales.Nombre_Especializacion,
           datos_Personales.Institucion_Espe,
           datos_Personales.Periodo_Espe,
           datos_Personales.Año_Titulacion_Espe,
           datos_Personales.Nombre_Curso,
           datos_Personales.Instituto_Curso,
           datos_Personales.Horas,
           datos_Personales.Fecha,
           datos_Personales.Idioma,
           datos_Personales.Habla,
           datos_Personales.Lee,
           datos_Personales.Escribe,
           datos_Personales.Dominio,
           datos_Personales.Actividad_Puesto,
           datos_Personales.Organizacion_Empresa,
           datos_Personales.Periodo,
           datos_Personales.Actividad_Puesto2,
           datos_Personales.Organizacion_Empresa2,
           datos_Personales.Periodo2,
           datos_Personales.Actividad_Puesto3,
           datos_Personales.Organizacion_Empresa3,
           datos_Personales.Periodo3,
           datos_Personales.Actividad_Puesto_Aca,
           datos_Personales.Institucion_Aca,
           datos_Personales.Periodo_Aca,
           datos_Personales.Actividad_Puesto_Aca2,
           datos_Personales.Institucion_Aca2,
           datos_Personales.Periodo_Aca2,
           datos_Personales.Actividad_Puesto_Aca3,
           datos_Personales.Institucion_Aca3,
           datos_Personales.Periodo_Aca3,
           datos_Personales.Ingenieria_Industrial,
           datos_Personales.Ingenieria_Sistemas,
           datos_Personales.Tics,
           datos_Personales.Ingenieria_Gestion,
           datos_Personales.Ingenieria_Logistica,
          datos_Personales.Ingenieria_Industial_Dis,
          datos_Personales.Contador,
           datos_Personales.Ingenieria_Mecatronica,
           datos_Personales.Ingenieria_Gestion_Dis,
           datos_Personales.Ingenieria_Administracion,
           datos_Personales.Nombre_Materia_Ant,
           datos_Personales.Carrera_Ant,
           datos_Personales.Semestre_Ant,
           datos_Personales.Nombre_Materia_Ant2,
           datos_Personales.Carrera_Ant2,
           datos_Personales.Semestre_Ant2,
           datos_Personales.Nombre_Materia_Ant3,
           datos_Personales.Carrera_Ant3,
           datos_Personales.Semestre_Ant3,
           datos_Personales.Nombre_Materia_Ant4,
           datos_Personales.Carrera_Ant4,
           datos_Personales.Semestre_Ant4,
           datos_Personales.Nombre_Materia_Ant5,
           datos_Personales.Carrera_Ant5,
           datos_Personales.Semestre_Ant5,
           datos_Personales.Nombre_Materia_Ant6,
           datos_Personales.Carrera_Ant6,
           datos_Personales.Semestre_Ant6,
           datos_Personales.Nombre_Materia_Ant7,
           datos_Personales.Carrera_Ant7,
           datos_Personales.Semestre_Ant7,
           datos_Personales.Nombre_Materia_Ant8,
           datos_Personales.Carrera_Ant8,
           datos_Personales.Semestre_Ant8,
           datos_Personales.Nombre_Materia_Ant9,
           datos_Personales.Carrera_Ant9,
           datos_Personales.Semestre_Ant9,
           datos_Personales.Nombre_Materia_Imp,
           datos_Personales.Carrera_Imp,
           datos_Personales.Semestre_Imp,
           datos_Personales.Nombre_Materia_Imp2,
           datos_Personales.Carrera_Imp2,
           datos_Personales.Semestre_Imp2,
           datos_Personales.Nombre_Materia_Imp3,
           datos_Personales.Carrera_Imp3,
           datos_Personales.Semestre_Imp3,
           datos_Personales.Nombre_Materia_Imp4,
           datos_Personales.Carrera_Imp4,
           datos_Personales.Semestre_Imp4,
           datos_Personales.Nombre_Materia_Imp5,
           datos_Personales.Carrera_Imp5,
           datos_Personales.Semestre_Imp5,
            datos_Personales.Nombre_Materia_Imp6,
           datos_Personales.Carrera_Imp6,
           datos_Personales.Semestre_Imp6,
           datos_Personales.Nombre_Materia_Imp7,
           datos_Personales.Carrera_Imp7,
           datos_Personales.Semestre_Imp7,
           datos_Personales.Nombre_Materia_Imp8,
           datos_Personales.Carrera_Imp8,
           datos_Personales.Semestre_Imp8,
           datos_Personales.Nombre_Materia_Imp9,
           datos_Personales.Carrera_Imp9,
           datos_Personales.Semestre_Imp9,
           datos_Personales.Nombre_Materia_Imp10,
           datos_Personales.Carrera_Imp10, datos_Personales.Semestre_Imp10);

                    if (Add > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se agrego con exito";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                        return response;


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al Agregar";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                        return response;


                    }


                }



            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                return response;
            }




        }


        public static ML.Response.Datos_PersonalesResponse Delete(int ID)
        {
            ML.Response.Datos_PersonalesResponse response = new ML.Response.Datos_PersonalesResponse();
            try
            {
                using (DL.DisponibilidadEntities3 context
                    = new DL.DisponibilidadEntities3())
                {
                    var Delete = context.SP_Datos_Personales_Delete(ID);

                    if (Delete > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se Elimino con exito";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                        return response;


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Ocurrio un Error";
                        response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                        return response;


                    }




                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta Con sistemas" + ex;
                response.Datos_PersonalesList = new List<ML.Entities.Datos_Personales>();
                return response;
            }



        }

    }
}
