using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Make { get; set; } 
        public string Model { get; set; } 
        public string Year { get; set; } 
        public decimal EngineSize { get; set; }
        public void PrintStats();
  
        
            
        
        
    }
}
