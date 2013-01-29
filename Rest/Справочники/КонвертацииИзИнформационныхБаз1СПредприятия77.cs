
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77")]
	[Route("/Catalogs/KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77/{Code}")]
	public class KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Request/*������������������������������1������������77������*/: V82.�����������������.������������������������������1������������77,IReturn<KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Request>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Response//������������������������������1������������77�����
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77s")]
	[Route("/Catalogs/KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77s/{Codes}")]
	public class KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77sRequest/*������������������������������1������������77������*/: IReturn<List<KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Request>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77sRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77sResponse//������������������������������1������������77�����
	{
		public string Result {get;set;}
	}


	public class KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Service /*������������������������������1������������77������*/ : Service
	{
		public object Any(KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Request request)
		{
			return new KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Response {Result = "Tovar, " + request.Code};
		}

		public object Get(KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Request request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������1������������77.�����������(���������);
				if (������ == null)
				{
					return new KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77Response() {Result = "������������������������������1������������77 c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������1������������77.�����������(1);
			}
		}

		public object Get(KonvertaciiIzInformacionnykhBaz1SPredpriyatiya77sRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������1������������77>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������1������������77.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
