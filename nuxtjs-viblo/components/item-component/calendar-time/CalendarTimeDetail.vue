<template>
  <div class="detail">
    <div class="detail-navbar">

      <div class="detail-navbar-block">

<div class="detail-navbar-title">Chỉnh sửa {{ phoneItem.title }}</div>
<div class="detail-navbar-line"></div>

<div class="detail-navbar-content-title-block">
    <div class="detail-navbar-content-title">Tiêu đề</div>
    <div class="detail-navbar-content-input">
        <input type="text" width="100%" v-model="phoneItem.name"  class="form__field ">
    </div>

</div>
<div class="detail-navbar-content-description-block">
    <div class="detail-navbar-content-title">Mô tả</div>
    <div class="detail-navbar-description-input">
        <textarea name="" id="" cols="30" rows="6" class="form__field "
            v-model="phoneItem.description"></textarea>
    </div>

</div>
<div class="detail-navbar-content-status-block">
    <div class="detail-navbar-content-title">Bắt buộc</div>
    <div class="detail-navbar-status-input"></div>

</div>
<div class="detail-navbar-content-status-block">
    <div class="detail-navbar-content-title">Xác thực OTP</div>
    <div class="detail-navbar-status-input"></div>

</div>
<div class="detail-navbar-line-2"></div>
<div class="detail-navbar-footer-block">
    <div class="detail-navbar-cancel-btn" @click="goBack">Hủy</div>
    <div class="detail-navbar-save-btn" @click="save">Lưu chỉnh sửa</div>

</div>


</div>
    </div>
      <div class="detail-form-block">
          <div class="detail-form-content-block">
              <div class="detail-form-content-center-block">
                  <div class="detail-form-content-center-title-block">
                      <div class="detail-form-content-center-title">{{ phoneItem.name }}</div>
                      <div class="detail-form-content-center-description">{{ phoneItem.description }}</div>
                  </div>
                  <div class="detail-form-content-center-input-block">
        <input type="datetime-local" width="100%" v-model="phoneItem.name"  class="form__field ">

                  </div>

              </div>
          </div>
      </div>
  </div>
</template>
<script>
import { v4 as uuidv4 } from 'uuid'

export default {
  components: {

  },
  props: {
      item: Object,
      groupIndex: Number,
  },
  data() {
      return {
          groups: [],
          phoneItem: this.item,
          activeGroupIndex: null,
      };
  },
  mounted() {
      if (this.item.is_create == true) {
          this.phoneItem = this.item;
          // this.phoneItem.is_create=false;
          this.loadFromLocalStorage();


      } else {

          this.loadFromLocalStorage();
          this.findItem();
      }

  },
  methods: {
      goBack() {
          this.$router.go(-1);
      },
      create() {
          debugger
          this.phoneItem.is_create = false;
          console.log(this.groups[this.groupIndex]);
          this.groups[this.groupIndex].items.push(this.phoneItem);

      },
      update() {
          const a = this.groups.filter(row => {
              return row
          });
          const b = this.item.id;
              a[this.groupIndex].items.forEach(element => {
                  if (element.id == b) {
                      console.log(element);
                      element = this.phoneItem;
                  }
      });

      },
      save() {
          if (this.phoneItem.is_create == true) {
              this.create();
          } else {
              this.update();
          }
          localStorage.setItem("myObject", JSON.stringify(this.groups));
          this.goBack();
      },
      loadFromLocalStorage() {
          const savedObject = localStorage.getItem("myObject");
          if (savedObject) {
              this.groups = JSON.parse(savedObject);


          }
      },
      findItem(){
          const a = this.groups.filter(row => {
                  return row
              });
              const b = this.item.id;
              for (var i = 0; i < a.length; i++) {
                  a[i].items.forEach(element => {
                      if (element.id == b) {
                          console.log(element);
                          this.phoneItem = element;
                      }
                  });
              }
      }
  }
}

</script>
<style scoped>
  @import '../../../assets/css/item-style/item-style.css';
</style>
