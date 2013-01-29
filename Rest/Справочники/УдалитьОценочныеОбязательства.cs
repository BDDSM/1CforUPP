
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UdalitOcenochnyeObyazatelstva")]
	[Route("/Catalogs/UdalitOcenochnyeObyazatelstva/{Code}")]
	public class UdalitOcenochnyeObyazatelstvaRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<UdalitOcenochnyeObyazatelstvaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UdalitOcenochnyeObyazatelstvaResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UdalitOcenochnyeObyazatelstvas")]
	[Route("/Catalogs/UdalitOcenochnyeObyazatelstvas/{Codes}")]
	public class UdalitOcenochnyeObyazatelstvasRequest/*�����������������������������������*/: IReturn<List<UdalitOcenochnyeObyazatelstvaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UdalitOcenochnyeObyazatelstvasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UdalitOcenochnyeObyazatelstvasResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class UdalitOcenochnyeObyazatelstvaService /*�����������������������������������*/ : Service
	{
		public object Any(UdalitOcenochnyeObyazatelstvaRequest request)
		{
			return new UdalitOcenochnyeObyazatelstvaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UdalitOcenochnyeObyazatelstvaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new UdalitOcenochnyeObyazatelstvaResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(UdalitOcenochnyeObyazatelstvasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
