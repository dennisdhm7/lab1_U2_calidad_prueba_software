namespace Math.Lib
{
    /// <summary>
    /// Proporciona métodos matemáticos personalizados para el cálculo de raíces cuadradas.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número positivo utilizando un método iterativo.
        /// </summary>
        /// <param name="input">Valor numérico del cual se desea obtener la raíz cuadrada. Debe ser positivo.</param>
        /// <returns>La raíz cuadrada del número especificado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza cuando el valor de <paramref name="input"/> es menor o igual a cero.
        /// </exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(input),
                    "El valor ingresado es invalido, solo se puede ingresar números positivos");

            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}
