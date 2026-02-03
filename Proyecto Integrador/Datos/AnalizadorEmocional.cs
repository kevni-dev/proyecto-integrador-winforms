using Proyecto_Integrador.Datos;
using System;
using System.Collections.Generic;

namespace Proyecto_Integrador.Logica
{
    public class PerfilEmocional
    {
        public int NivelEstres { get; set; }
        public int NivelConfianza { get; set; }
        public int NivelActivacion { get; set; }
        public string EstadoGeneral { get; set; }
        public string Analisis { get; set; }
        public List<string> Recomendaciones { get; set; }
        public List<string> FactoresInfluyen { get; set; }
    }

    public static class AnalizadorEmocional
    {
        public static PerfilEmocional Analizar(Caballo caballo)
        {
            if (caballo == null)
                return null;

            var perfil = new PerfilEmocional
            {
                Recomendaciones = new List<string>(),
                FactoresInfluyen = new List<string>()
            };

            int baseEstres = CalcularEstresBase(caballo.Temperamento);
            int baseConfianza = CalcularConfianzaBase(caballo.Temperamento);
            int baseActivacion = CalcularActivacionBase(caballo.Temperamento);

            AjustarPorEdad(caballo.Edad, ref baseEstres, ref baseConfianza, ref baseActivacion, perfil.FactoresInfluyen);

            // Ajustar por sexo
            AjustarPorSexo(caballo.Sexo, ref baseEstres, ref baseActivacion, perfil.FactoresInfluyen);

            // Ajustar por raza
            AjustarPorRaza(caballo.Raza, ref baseEstres, ref baseConfianza, perfil.FactoresInfluyen);

            perfil.NivelEstres = Clamp(baseEstres, 0, 100);
            perfil.NivelConfianza = Clamp(baseConfianza, 0, 100);
            perfil.NivelActivacion = Clamp(baseActivacion, 0, 100);

            // Determinar estado general
            perfil.EstadoGeneral = DeterminarEstadoGeneral(perfil.NivelEstres, perfil.NivelActivacion);

            // Generar análisis textual
            perfil.Analisis = GenerarAnalisis(caballo, perfil);

            // Generar recomendaciones
            perfil.Recomendaciones = GenerarRecomendaciones(caballo, perfil);

            return perfil;
        }

        private static int CalcularEstresBase(string temperamento)
        {
            return temperamento.ToLower() switch
            {
                "tranquilo" => 20,
                "nervioso" => 75,
                "agresivo" => 80,
                "dócil" => 15,
                "enérgico" => 50,
                "activo" => 45,
                "tímido" => 60,
                "dominante" => 55,
                _ => 40
            };
        }

        private static int CalcularConfianzaBase(string temperamento)
        {
            return temperamento.ToLower() switch
            {
                "tranquilo" => 85,
                "nervioso" => 30,
                "agresivo" => 25,
                "dócil" => 90,
                "enérgico" => 65,
                "activo" => 70,
                "tímido" => 40,
                "dominante" => 60,
                _ => 50
            };
        }

        private static int CalcularActivacionBase(string temperamento)
        {
            return temperamento.ToLower() switch
            {
                "tranquilo" => 30,
                "nervioso" => 75,
                "agresivo" => 85,
                "dócil" => 35,
                "enérgico" => 80,
                "activo" => 75,
                "tímido" => 45,
                "dominante" => 70,
                _ => 50
            };
        }

        private static void AjustarPorEdad(int edad, ref int estres, ref int confianza, ref int activacion, List<string> factores)
        {
            if (edad >= 0 && edad <= 3)
            {
                // Potros: más nerviosos, menos confianza, muy activos
                estres += 15;
                confianza -= 20;
                activacion += 20;
                factores.Add($"• Edad: {edad} años\nLos potros suelen ser más inquietos y requieren manejo paciente.");
            }
            else if (edad >= 4 && edad <= 12)
            {
                // Adultos jóvenes: equilibrados
                estres -= 5;
                confianza += 10;
                factores.Add($"• Edad: {edad} años\nEn esta etapa el caballo suele tener mayor estabilidad emocional.");
            }
            else if (edad >= 13 && edad <= 20)
            {
                // Maduros: más estables
                estres -= 10;
                confianza += 15;
                activacion -= 10;
                factores.Add($"• Edad: {edad} años\nLos caballos maduros tienden a ser más tranquilos y predecibles.");
            }
            else if (edad > 20)
            {
                // Veteranos: muy tranquilos pero pueden tener limitaciones
                estres -= 15;
                confianza += 5;
                activacion -= 20;
                factores.Add($"• Edad: {edad} años\nLos caballos veteranos son generalmente muy calmados, pero requieren cuidados especiales.");
            }
        }

        private static void AjustarPorSexo(string sexo, ref int estres, ref int activacion, List<string> factores)
        {
            switch (sexo.ToLower())
            {
                case "macho":
                case "semental":
                    estres += 10;
                    activacion += 15;
                    factores.Add($"• Sexo: {sexo}\nLos sementales pueden presentar comportamientos más territoriales y enérgicos.");
                    break;
                case "hembra":
                case "yegua":
                    estres += 5;
                    factores.Add($"• Sexo: {sexo}\nLas yeguas pueden mostrar cambios de comportamiento según su ciclo hormonal.");
                    break;
                case "castrado":
                case "gelding":
                    estres -= 10;
                    activacion -= 5;
                    factores.Add($"• Sexo: {sexo}\nLos caballos castrados suelen ser más equilibrados emocionalmente.");
                    break;
            }
        }

        private static void AjustarPorRaza(string raza, ref int estres, ref int confianza, List<string> factores)
        {
            string razaLower = raza.ToLower();

            // Razas de sangre caliente (árabes, pura sangre)
            if (razaLower.Contains("árabe") || razaLower.Contains("arabe") ||
                razaLower.Contains("pura sangre") || razaLower.Contains("purasangre"))
            {
                estres += 10;
                confianza -= 5;
                factores.Add($"• Raza: {raza}\nLa raza puede influir en la sensibilidad y comportamiento general del caballo.");
            }
            // Razas de sangre fría (percherón, clydesdale)
            else if (razaLower.Contains("percherón") || razaLower.Contains("percheron") ||
                     razaLower.Contains("clydesdale") || razaLower.Contains("belga"))
            {
                estres -= 15;
                confianza += 10;
                factores.Add($"• Raza: {raza}\nLa raza puede influir en la sensibilidad y comportamiento general del caballo.");
            }
            // Razas de trabajo (cuarto de milla, criollo)
            else if (razaLower.Contains("cuarto") || razaLower.Contains("criollo") ||
                     razaLower.Contains("paint"))
            {
                estres -= 5;
                confianza += 5;
                factores.Add($"• Raza: {raza}\nLa raza puede influir en la sensibilidad y comportamiento general del caballo.");
            }
            else
            {
                factores.Add($"• Raza: {raza}\nLa raza puede influir en la sensibilidad y comportamiento general del caballo.");
            }
        }

        private static string DeterminarEstadoGeneral(int estres, int activacion)
        {
            if (estres < 30 && activacion < 40)
                return "Tranquilo";
            else if (estres < 40 && activacion < 60)
                return "Relajado";
            else if (estres >= 40 && estres < 60 && activacion >= 40 && activacion < 70)
                return "Alerta";
            else if (estres >= 60 || activacion >= 70)
                return "Nervioso";
            else
                return "Equilibrado";
        }

        private static string GenerarAnalisis(Caballo caballo, PerfilEmocional perfil)
        {
            string intro = $"Basándose en las características de {caballo.Nombre}, ";

            string nivelEstres = perfil.NivelEstres < 40 ? "bajos niveles de estrés" :
                                perfil.NivelEstres < 70 ? "niveles moderados de estrés" :
                                "niveles elevados de estrés";

            string disposicion = perfil.NivelConfianza > 70 ? "excelente disposición" :
                                perfil.NivelConfianza > 50 ? "buena disposición" :
                                perfil.NivelConfianza > 30 ? "disposición moderada" :
                                "disposición limitada";

            string conclusion = perfil.NivelEstres < 40 && perfil.NivelConfianza > 60 ?
                "lo que sugiere un adecuado bienestar emocional y buenas condiciones para la interacción humana." :
                perfil.NivelEstres >= 60 || perfil.NivelConfianza < 40 ?
                "por lo que se recomienda un manejo cuidadoso y progresivo, respetando sus límites emocionales." :
                "lo que indica un estado emocional dentro de parámetros normales, con espacio para fortalecer la confianza.";

            return $"{intro}el análisis muestra {nivelEstres} y una {disposicion} a la interacción, {conclusion}";
        }

        private static List<string> GenerarRecomendaciones(Caballo caballo, PerfilEmocional perfil)
        {
            var recomendaciones = new List<string>();

            // Basadas en nivel de estrés
            if (perfil.NivelEstres > 60)
            {
                recomendaciones.Add("• Reducir estímulos externos");
                recomendaciones.Add("• Evitar movimientos bruscos");
                recomendaciones.Add("• Mantener rutinas predecibles");
            }
            else if (perfil.NivelEstres < 30)
            {
                recomendaciones.Add("• Apto para actividades de aprendizaje");
                recomendaciones.Add("• Puede manejar nuevos estímulos gradualmente");
            }

            // Basadas en nivel de confianza
            if (perfil.NivelConfianza < 40)
            {
                recomendaciones.Add("• Interacción progresiva y paciente");
                recomendaciones.Add("• Reforzar comportamientos positivos");
                recomendaciones.Add("• Construir confianza con consistencia");
            }
            else if (perfil.NivelConfianza > 70)
            {
                recomendaciones.Add("• Ideal para trabajo con principiantes");
                recomendaciones.Add("• Responde bien a técnicas de refuerzo positivo");
            }

            // Basadas en activación
            if (perfil.NivelActivacion > 70)
            {
                recomendaciones.Add("• Proporcionar ejercicio regular");
                recomendaciones.Add("• Canalizar energía con actividades estructuradas");
            }
            else if (perfil.NivelActivacion < 30)
            {
                recomendaciones.Add("• Estimulación moderada recomendada");
            }

            // Basadas en temperamento específico
            switch (caballo.Temperamento.ToLower())
            {
                case "nervioso":
                case "tímido":
                    recomendaciones.Add("• Ambiente tranquilo y predecible");
                    break;
                case "agresivo":
                case "dominante":
                    recomendaciones.Add("• Manejo firme pero justo");
                    recomendaciones.Add("• Establecer límites claros");
                    break;
                case "enérgico":
                case "activo":
                    recomendaciones.Add("• Actividades físicas regulares");
                    break;
            }

            if (recomendaciones.Count == 0)
            {
                recomendaciones.Add("• Continuar con manejo habitual");
                recomendaciones.Add("• Observar cambios en comportamiento");
            }

            return recomendaciones;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
