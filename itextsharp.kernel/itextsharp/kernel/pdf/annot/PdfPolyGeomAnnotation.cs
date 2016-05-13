/*
$Id: b5b94343b89fa056bf2d2a87ed252693673bc5b1 $

This file is part of the iText (R) project.
Copyright (c) 1998-2016 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using iTextSharp.Kernel.Geom;
using iTextSharp.Kernel.Pdf;

namespace iTextSharp.Kernel.Pdf.Annot
{
	public class PdfPolyGeomAnnotation : PdfMarkupAnnotation
	{
		private const long serialVersionUID = -9038993253308315792L;

		/// <summary>Subtypes</summary>
		public static readonly PdfName Polygon = PdfName.Polygon;

		public static readonly PdfName PolyLine = PdfName.PolyLine;

		public PdfPolyGeomAnnotation(Rectangle rect, PdfName subtype, float[] vertices)
			: base(rect)
		{
			SetSubtype(subtype);
			SetVertices(vertices);
		}

		public PdfPolyGeomAnnotation(PdfDictionary pdfObject)
			: base(pdfObject)
		{
		}

		public static iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation CreatePolygon(Rectangle
			 rect, float[] vertices)
		{
			return new iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation(rect, Polygon, vertices
				);
		}

		public static iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation CreatePolyLine(Rectangle
			 rect, float[] vertices)
		{
			return new iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation(rect, PolyLine, vertices
				);
		}

		public override PdfName GetSubtype()
		{
			return GetPdfObject().GetAsName(PdfName.Subtype);
		}

		public virtual PdfArray GetVertices()
		{
			return GetPdfObject().GetAsArray(PdfName.Vertices);
		}

		public virtual iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation SetVertices(PdfArray
			 vertices)
		{
			return (iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation)Put(PdfName.Vertices, vertices
				);
		}

		public virtual iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation SetVertices(float
			[] vertices)
		{
			return (iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation)Put(PdfName.Vertices, new 
				PdfArray(vertices));
		}

		public virtual PdfArray GetLineEndingStyles()
		{
			return GetPdfObject().GetAsArray(PdfName.LE);
		}

		public virtual iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation SetLineEndingStyles
			(PdfArray lineEndingStyles)
		{
			return (iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation)Put(PdfName.LE, lineEndingStyles
				);
		}

		public virtual PdfDictionary GetMeasure()
		{
			return GetPdfObject().GetAsDictionary(PdfName.Measure);
		}

		public virtual iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation SetMeasure(PdfDictionary
			 measure)
		{
			return (iTextSharp.Kernel.Pdf.Annot.PdfPolyGeomAnnotation)Put(PdfName.Measure, measure
				);
		}

		private void SetSubtype(PdfName subtype)
		{
			Put(PdfName.Subtype, subtype);
		}
	}
}
