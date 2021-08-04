using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Presentacion.Soportes
{
    public class DatosValidacion
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool valid;
        private string message;

       public DatosValidacion(object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, results, true);
        }

        public bool Validado()
        {
            if (valid == false)
            {
                foreach (ValidationResult item in results)
                {
                    message += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(message);
            }
            return valid;
        }
    }
}
