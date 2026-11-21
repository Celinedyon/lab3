using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace EmployeeManagementSystem.View
{
    internal static class PayslipPdfExporter
    {
        public static void Save(string path, IEnumerable<string> lines)
        {
            var content = new StringBuilder();
            content.Append("BT\n/F1 20 Tf\n50 750 Td\n(PAYSLIP) Tj\n/F1 11 Tf\n0 -38 Td\n");
            foreach (string line in lines)
            {
                content.Append("(").Append(Escape(line)).Append(") Tj\n0 -24 Td\n");
            }
            content.Append("ET");

            byte[] stream = Encoding.ASCII.GetBytes(content.ToString());
            var objects = new List<byte[]>
            {
                Encoding.ASCII.GetBytes("<< /Type /Catalog /Pages 2 0 R >>"),
                Encoding.ASCII.GetBytes("<< /Type /Pages /Kids [3 0 R] /Count 1 >>"),
                Encoding.ASCII.GetBytes("<< /Type /Page /Parent 2 0 R /MediaBox [0 0 612 792] " +
                    "/Resources << /Font << /F1 4 0 R >> >> /Contents 5 0 R >>"),
                Encoding.ASCII.GetBytes("<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica >>"),
                BuildStreamObject(stream)
            };

            using (var output = new MemoryStream())
            {
                WriteAscii(output, "%PDF-1.4\n");
                var offsets = new List<long>();
                for (int i = 0; i < objects.Count; i++)
                {
                    offsets.Add(output.Position);
                    WriteAscii(output, (i + 1).ToString(CultureInfo.InvariantCulture) + " 0 obj\n");
                    output.Write(objects[i], 0, objects[i].Length);
                    WriteAscii(output, "\nendobj\n");
                }

                long xrefOffset = output.Position;
                WriteAscii(output, "xref\n0 " + (objects.Count + 1).ToString(CultureInfo.InvariantCulture) +
                    "\n0000000000 65535 f \n");
                foreach (long offset in offsets)
                    WriteAscii(output, offset.ToString("D10", CultureInfo.InvariantCulture) + " 00000 n \n");
                WriteAscii(output, "trailer\n<< /Size " + (objects.Count + 1).ToString(CultureInfo.InvariantCulture) +
                    " /Root 1 0 R >>\nstartxref\n" + xrefOffset.ToString(CultureInfo.InvariantCulture) + "\n%%EOF");
                File.WriteAllBytes(path, output.ToArray());
            }
        }

        private static byte[] BuildStreamObject(byte[] stream)
        {
            using (var output = new MemoryStream())
            {
                WriteAscii(output, "<< /Length " + stream.Length.ToString(CultureInfo.InvariantCulture) + " >>\nstream\n");
                output.Write(stream, 0, stream.Length);
                WriteAscii(output, "\nendstream");
                return output.ToArray();
            }
        }

        private static string Escape(string value)
        {
            string ascii = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(value ?? string.Empty));
            return ascii.Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)");
        }

        private static void WriteAscii(Stream stream, string value)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(value);
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
