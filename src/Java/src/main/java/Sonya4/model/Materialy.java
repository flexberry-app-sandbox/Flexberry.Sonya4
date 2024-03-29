package Sonya4.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Sonya4.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;


/**
 * Entity implementation class for Entity: Материалы
 */
@Entity(name = "IISSonya4Материалы")
@Table(schema = "public", name = "Материалы")
public class Materialy {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "ID")
    private Integer id;

    @Column(name = "Наименование")
    private String наименование;

    @Column(name = "Марка")
    private String марка;

    @Column(name = "Единицы")
    private String единицы;

    @Column(name = "Стоимость")
    private Integer стоимость;


    public Materialy() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Integer getID() {
      return id;
    }

    public void setID(Integer id) {
      this.id = id;
    }

    public String getНаименование() {
      return наименование;
    }

    public void setНаименование(String наименование) {
      this.наименование = наименование;
    }

    public String getМарка() {
      return марка;
    }

    public void setМарка(String марка) {
      this.марка = марка;
    }

    public String getЕдиницы() {
      return единицы;
    }

    public void setЕдиницы(String единицы) {
      this.единицы = единицы;
    }

    public Integer getСтоимость() {
      return стоимость;
    }

    public void setСтоимость(Integer стоимость) {
      this.стоимость = стоимость;
    }


}