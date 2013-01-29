
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TekhnologicheskieKartyProizvodstva")]
	[Route("/Catalogs/TekhnologicheskieKartyProizvodstva/{Code}")]
	public class TekhnologicheskieKartyProizvodstvaRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<TekhnologicheskieKartyProizvodstvaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TekhnologicheskieKartyProizvodstvaResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TekhnologicheskieKartyProizvodstvas")]
	[Route("/Catalogs/TekhnologicheskieKartyProizvodstvas/{Codes}")]
	public class TekhnologicheskieKartyProizvodstvasRequest/*��������������������������������������*/: IReturn<List<TekhnologicheskieKartyProizvodstvaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TekhnologicheskieKartyProizvodstvasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TekhnologicheskieKartyProizvodstvasResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class TekhnologicheskieKartyProizvodstvaService /*��������������������������������������*/ : Service
	{
		public object Any(TekhnologicheskieKartyProizvodstvaRequest request)
		{
			return new TekhnologicheskieKartyProizvodstvaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TekhnologicheskieKartyProizvodstvaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new TekhnologicheskieKartyProizvodstvaResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(TekhnologicheskieKartyProizvodstvasRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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
